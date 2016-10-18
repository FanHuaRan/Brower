using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MvvmDemo;
using MyDemo.Common;
using MyDemo.Enity;

namespace MyDemo
{
    public class BrowserHelper
    {
        /// <summary>
        /// 得到全体目录
        /// </summary>
        /// <returns></returns>
        public List<Catalog> GetCatalogList()
        {
            List<Catalog> catalogs = new List<Catalog>();
            DataTable dt = SqliteHelper.ExecuteDataTable("select * from catalog", null);
            foreach (DataRow dr in dt.Rows)
            {
                Catalog cata = new Catalog();
                cata.CatalogID = int.Parse(dr[0].ToString());
                cata.CatalogName = dr[1].ToString();
                catalogs.Add(cata);
            }
            return catalogs;
        }
       /// <summary>
       /// 根据sql语句得到对应的目录
       /// </summary>
       /// <param name="selectStr"></param>
       /// <returns></returns>
        public List<Catalog> GetCatalogList(string selectStr)
        {
            List<Catalog> catalogs = new List<Catalog>();
            DataTable dt = SqliteHelper.ExecuteDataTable(selectStr, null);
            foreach (DataRow dr in dt.Rows)
            {
                Catalog cata = new Catalog();
                cata.CatalogID = int.Parse(dr[0].ToString());
                cata.CatalogName = dr[1].ToString();
                catalogs.Add(cata);
            }
            return catalogs;
        }
        /// <summary>
        /// 得到全体历史纪录,排序默认为降序
        /// </summary>
        /// <returns></returns>
        public List<Record> GetRecordList()
        {
            List<Record> reList = new List<Record>();
            DataTable recordTable = SqliteHelper.ExecuteDataTable("select * from Record order by recordid desc", null);
            foreach (DataRow row in recordTable.Rows)
            {
                Record record = new Record();
                record.RecordID = int.Parse(row[0].ToString());
                record.Title = row[1].ToString();
                record.Url = row[2].ToString();
                reList.Add(record);
            }
            return reList;
        }
        /// <summary>
        /// 根据sql语句得到对应的历史纪录，
        /// </summary>
        /// <param name="selectStr"></param>
        /// <returns></returns>
        public List<Record> GetRecordList(string selectStr)
        {
            List<Record> reList = new List<Record>();
            DataTable recordTable = SqliteHelper.ExecuteDataTable(selectStr, null);
            foreach (DataRow row in recordTable.Rows)
            {
                Record record = new Record();
                record.RecordID = int.Parse(row[0].ToString());
                record.Title = row[1].ToString();
                record.Url = row[2].ToString();
                reList.Add(record);
            }
            return reList;
        }
        /// <summary>
        /// 得到全体书签
        /// </summary>
        /// <returns></returns>
        public List<BookMark> GetBookMarkList()
        {
            List<BookMark> bookMarks = new List<BookMark>();
            DataTable dt = SqliteHelper.ExecuteDataTable("select * from BookMark", null);
            foreach (DataRow dr in dt.Rows)
            {
                BookMark bm = new BookMark();
                bm.BookMarkID = int.Parse(dr[0].ToString());
                bm.Title = dr[1].ToString();
                bm.Url = dr[2].ToString();
                if (dr[3].ToString() != "")
                    bm.CatalogID = int.Parse(dr[3].ToString());
                bookMarks.Add(bm);
            }
            return bookMarks;
        }
        /// <summary>
        /// 根据sql语句得到对应的书签
        /// </summary>
        /// <param name="selectStr"></param>
        /// <returns></returns>
        public List<BookMark> GetBookMarkList(string selectStr)
        {
            List<BookMark> bookMarks = new List<BookMark>();
            DataTable dt = SqliteHelper.ExecuteDataTable("select * from BookMark", null);
            foreach (DataRow dr in dt.Rows)
            {
                BookMark bm = new BookMark();
                bm.BookMarkID = int.Parse(dr[0].ToString());
                bm.Title = dr[1].ToString();
                bm.Url = dr[2].ToString();
                if (dr[3].ToString() != "")
                    bm.CatalogID = int.Parse(dr[3].ToString());
                bookMarks.Add(bm);
            }
            return bookMarks;
        }
        /// <summary>
        /// 得到书签字典
        /// </summary>
        /// <param name="bookMarks"></param>
        /// <returns></returns>
        public Dictionary<string, string> GetBookMarkDic(List<BookMark> bookMarks)
        {
            Dictionary<string,string> bookMarkDic=new Dictionary<string, string>();
            foreach (var v in bookMarks)
            {
                bookMarkDic.Add(v.Title,v.Url);
            }
            return bookMarkDic;
        }
        /// <summary>
        /// 得到历史字典
        /// </summary>
        /// <param name="records"></param>
        /// <returns></returns>
        public Dictionary<string, string> GetRecordDic(List<Record> records)
        {
            Dictionary<string,string> recordDic=new Dictionary<string, string>();
            foreach (var v in records)
            {
                recordDic.Add(v.Title,v.Url);
            }
            return recordDic;
        }
        /// <summary>
        /// 更新历史纪录
        /// </summary>
        /// <param name="title"></param>
        /// <param name="url"></param>
        public void InsertToRecord(Record record)
        {
            //首先删除相同标题和地址的记录
            int n=SqliteHelper.ExecuteNonce(
                string.Format("delete from record where title='{0}' ", record.Title), null);
            //增加记录
            DataTable dt = SqliteHelper.ExecuteDataTable("select * from Record where 0=1", null);
            DataRow drRow = dt.NewRow();
            drRow["Title"] = record.Title;
            drRow["Url"] = record.Url;
            dt.Rows.Add(drRow);
            SqliteHelper.UpdateTable("Record", "RecordID", dt);
        }
        /// <summary>
        /// 删除所有历史记录
        /// </summary>
        /// <param name="deleteStr"></param>
        public void DeleteRecord(string deleteStr)
        {
            SqliteHelper.ExecuteNonce(deleteStr, null);
        }
        /// <summary>
        /// 增加书签
        /// </summary>
        /// <param name="bm"></param>
        public void InsertBookMark(BookMark bm)
        {
            //存在相同书签 则直接返回
            string selectStr = string.Format("select  *　from BookMark where title='{0}' and url='{1}'", bm.Title, bm.Url);
            if (bm.CatalogID == null) selectStr += " and catalogid  is null";
            else selectStr +=("and catalogid = "+bm.CatalogID);
            int n = SqliteHelper.ExecuteNonce(selectStr, null);
            if(n>0) return;
            //增加或者更新书签
            DataTable dt = SqliteHelper.ExecuteDataTable("select * from BookMark where 0 =1", null);
            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
            dr["BookMarkID"] = bm.BookMarkID;
            dr["Title"] = bm.Title;
            dr["Url"] = bm.Url;
            dr["CatalogID"] = bm.CatalogID;
            SqliteHelper.UpdateTable("BookMark", "BookMarkID", dt);
        }
        /// <summary>
        /// 删除书签
        /// </summary>
        /// <param name="selectStr"></param>
        public void DeleteBookMark(string deleteStr)
        {
            SqliteHelper.ExecuteNonce(deleteStr, null);
        }
        /// <summary>
        /// 更新目录表
        /// </summary>
        /// <param name="bm"></param>
        public void InsertCatalog(Catalog bm)
        {
           //检查是否已经存在目录
            int n =
                SqliteHelper.ExecuteNonce(string.Format("select * from catalog where catalogname={0}",bm.CatalogName),
                    null);
            if (n > 0) return;
            //更新表
            DataTable dt = SqliteHelper.ExecuteDataTable("select * from catalog where 0=1", null);
            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
            dr[0] = bm.CatalogID;
            dr[1] = bm.CatalogName;
            SqliteHelper.UpdateTable("Catalog", "Catalogid", dt);
        } 
    }
}
