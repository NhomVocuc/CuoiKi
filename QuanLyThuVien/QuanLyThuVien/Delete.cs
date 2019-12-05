using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Abacre
{
    class Delete
    {
        public int Deletet_Item_Categories(int itemcat)
        {
            nhancautruyvan a = new nhancautruyvan();
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [ItemCat] where itemcatid="+itemcat+"");
            try
            {
                int t = (int)myCommand.ExecuteNonQuery();
                a.dong();
                return t;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int Delete_Item_by_itemid(int itemid)
        {
            nhancautruyvan a = new nhancautruyvan();
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [Item] where itemid=" + itemid + "");
             try
            {
            int t = (int)myCommand.ExecuteNonQuery();
            a.dong();
            return t;
            }
             catch (Exception e)
             {
                 return 0;
             }
        }

        public int Delete_Table(string table)
        {
            nhancautruyvan a = new nhancautruyvan();
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [table1] where code='" + table + "'");
            try
            {
            int t = (int)myCommand.ExecuteNonQuery();
            a.dong();
            return t;
             }
            catch (Exception e)
            {
                return 0;
            }
        }
        public int Delete_order(int orderid)
        {
            nhancautruyvan a = new nhancautruyvan();
            
            int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [order1] where orderid=" + orderid1 + "");
            try
            {
            int t = (int)myCommand.ExecuteNonQuery();
            a.dong();
            return t;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public int Delete_Discount(int iddisc)
        {
            nhancautruyvan a = new nhancautruyvan();
           // int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [OrderDisc] where orderdiscid=" + iddisc + "");
            try
            {
            int t = (int)myCommand.ExecuteNonQuery();
            a.dong();
            return t;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int Delete_MenuItem(int orderid,int itemid)
        {
            nhancautruyvan a = new nhancautruyvan();
            // int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [MenuItem] where orderid=" + orderid + " and itemid="+itemid+"");
             try
            {
            int t = (int)myCommand.ExecuteNonQuery();
            a.dong();
            return t;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int Delete_Some_Order(string t1, string t2)
        {
            string time1=t1;
            string time2 = t2;
             try
            {
            nhancautruyvan a = new nhancautruyvan();
            // int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [order1] where [order1].sdate between " + time1 + " and " + time2 + ";");
            int t = (int)myCommand.ExecuteNonQuery();
            a.dong();
            return t;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int Delete_Worker(int workerid)
        {
            nhancautruyvan a = new nhancautruyvan();
            // int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [Worker] where workerid=" + workerid + " ");
            int t = (int)myCommand.ExecuteNonQuery();
            a.dong();
            return t;
        }

        public int Delete_InvCat(int invcatid)
        {
            nhancautruyvan a = new nhancautruyvan();
            // int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [invcat] where invcatid=" + invcatid + " ");
             try
            {
            int t = (int)myCommand.ExecuteNonQuery();
            a.dong();
            return t;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public int Delete_Voitem(int voitemid)
        {
            nhancautruyvan a = new nhancautruyvan();
            // int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [voitem] where voitemid=" + voitemid + " ");
            try
            {
            int t = (int)myCommand.ExecuteNonQuery();
            a.dong();
            return t;
            }
            catch (Exception e)
            {
                
                MessageBox.Show(e+"");
                return 0;
            }
        }

        public int Delete_Vorder(int vorderid)
        {
            nhancautruyvan a = new nhancautruyvan();
            // int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [vorder] where vorderid=" + vorderid + " ");
            try
            {
                int t = (int)myCommand.ExecuteNonQuery();
                a.dong();
                return t;
            }
            catch (Exception e)
            {

                MessageBox.Show(e + "");
                return 0;
            }
        }

        public int Delete_Voitem_by_vorderid(int vorderid)
        {
            nhancautruyvan a = new nhancautruyvan();
            // int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [voitem] where vorderid=" + vorderid + " ");
            try
            {
                int t = (int)myCommand.ExecuteNonQuery();
                a.dong();
                return t;
            }
            catch (Exception e)
            {

                MessageBox.Show(e + "");
                return 0;
            }
        }

        public int Delete_Vendor(int vendorid)
        {
            nhancautruyvan a = new nhancautruyvan();
            // int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [vendor] where vendorid=" + vendorid + " ");
           
                int t = (int)myCommand.ExecuteNonQuery();
                a.dong();
                return t;
            
        }

        public int Delete_payoption(int payoptionid)
        {
            nhancautruyvan a = new nhancautruyvan();
            // int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [payoption] where payoptionid=" + payoptionid + " ");

            int t = (int)myCommand.ExecuteNonQuery();
            a.dong();
            return t;

        }
//delete thành phần trong một item
        public int Delete_Itemcomp(int itemcompid)
        {
            nhancautruyvan a = new nhancautruyvan();
            // int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [itemcomp] where itemcompid=" + itemcompid + " ");
            int t = (int)myCommand.ExecuteNonQuery();
            a.dong();
            return t;
        }
//delete some item from menuitem by orderid
        public int Delete_Item_byorderid(int orderid)
        {
            nhancautruyvan a = new nhancautruyvan();
            // int orderid1 = Convert.ToInt32(orderid);
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [menuitem] where orderid=" + orderid + " ");
            int t = (int)myCommand.ExecuteNonQuery();
            a.dong();
            return t;
        }


        public int Delete_Card(string  IDCard)
        {
            nhancautruyvan a = new nhancautruyvan();
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [Card] where IDCard='" + IDCard + "'");
            try
            {
                int t = (int)myCommand.ExecuteNonQuery();
                a.dong();
                return t;
            }
            catch (Exception e)
            {
                MessageBox.Show("không thể xóa do ràng buộc");
                return 0;
            }
        }

        public int Delete_Area(int areaid)
        {
            nhancautruyvan a = new nhancautruyvan();
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [Area] where [ID_Khu]=" + areaid + "");
            try
            {
                int t = (int)myCommand.ExecuteNonQuery();
                a.dong();
                return t;
            }
            catch (Exception e)
            {
                MessageBox.Show(e+"");
                return 0;
            }
        }
        public int Delete_EmailMsg(int emailmsgid)
        {
            nhancautruyvan a = new nhancautruyvan();
            SqlCommand myCommand = (SqlCommand)a.getquery("delete from [EmailMsg] where [emailmsgid]=" + emailmsgid + "");
            try
            {
                int t = (int)myCommand.ExecuteNonQuery();
                a.dong();
                return t;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
