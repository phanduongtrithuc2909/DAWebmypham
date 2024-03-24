using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webmypham.Models
{
    public class DANHMUC
    {
        public int IdDM { get; set; }
        public string TenDM { get; set; }

        public DANHMUC(int id, string ten)
        {
            IdDM = id;
            TenDM = ten;
        }
    }
}