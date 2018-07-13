using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROFINET_STEP_7.Entity
{
    public class FData
    {
        private string _Address;

        private object _Value;

        public FData() { }

        public FData(string address, object value)
        {
            this.Address = address;
            this.Value = value;
        }

        public object Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
    }
}
