using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_lastproject.ConnectSql
{
    class getCart
    {
        private int cartid;
        private int userid;
        private int createat;
        private int orid;

        public getCart()
        {
        }

        public getCart(int id, int userid, int createat, int orid)
        {
            this.cartid = id;
            this.userid = userid;
            this.createat = createat;
            this.orid = orid;
        }

        public int Id { get => cartid; set => cartid = value; }
        public int Userid { get => userid; set => userid = value; }
        public int Createat { get => createat; set => createat = value; }
        public int Orid { get => orid; set => orid = value; }
    }
}
