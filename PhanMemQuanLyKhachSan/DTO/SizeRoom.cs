using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DTO
{
    public class SizeRoom
    {
        public SizeRoom(DataRow row)
        {
            this.IdSizeRoom = (int)row["IdSizeRoom"];
            this.Size = (int)row["SizeRoom"];
        }

        private int idSizeRoom;
        private int size;

        public int IdSizeRoom { get => idSizeRoom; set => idSizeRoom = value; }
        public int Size { get => size; set => size = value; }
    }
}
