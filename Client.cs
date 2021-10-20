using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    class Client
    {
        int id;
        Dictionary<string, string> data;
        public int ID { get => this.id; set => this.id = value; }
        public Dictionary<string, string> Data { get => this.data; set => this.Data = value; }
        public Client()
        {
            this.id = -1;
            this.data = new Dictionary<string, string>();
        }
        public override string ToString()
        {
            string msg = "instance of (Client)\n\t[id='" + this.id.ToString() + "']";
            foreach (KeyValuePair<string, string> kvp in this.data)
            {
                if (DateTime.TryParse(kvp.Value, out DateTime data))
                    msg += string.Format("\n\t[{0}='{1}']", kvp.Key, data.ToString("dd/MM/yyyy"));
                else
                    msg += string.Format("\n\t[{0}='{1}']", kvp.Key.ToString(), kvp.Value.ToString());
            }
            return msg;
        }
    }
}
