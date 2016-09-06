using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DAL.Classes;

namespace Customer
{
    public static class Helper
    {
        public static CUSTOMER_SQLEntities DataBase()
        {
            var DataModel = EDM.DBEntity();
            return DataModel;
        }
        public static void DoIt(object src, object desc)
        {
            var type = src.GetType();
            var d_type = desc.GetType();
            var src_list = type.GetProperties().Select(i => i.Name);
            var desc_list = d_type.GetProperties().Select(i => i.Name);

            var same_list = src_list.Where(i => desc_list.Contains(i)).ToList();

            foreach (var item in same_list)
            {
                var val = type.GetProperty(item).GetValue(src, null);

                d_type.GetProperty(item).SetValue(desc, val, null);

            }
        }
        public static string TextLength(string text,int length)
        {
            string Text = "";
            if (text.Length>length)
            {
                Text = text.Substring(0, length)+"...";
            }
            else
            {
                Text = text;
            }
            return Text;
        }

    }
}