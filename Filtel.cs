using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SuperMaket_project
{
    public class Filtel
    {
        public bool isEmail(string Email)
        {
            return Regex.IsMatch(Email, @"[A-z 0-9]{6,50}@[A-z 0-9]{2,50}(\.[A-z]{2,10})+");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="typeFix">0=remove ' <br> 1=remove speces</br><br> othar = all </br> </param>
        /// <returns></returns>
        public string FixText(string text,int typeFix = 0)
        {
            switch (typeFix)
            {
                case 0:
                    return text.Replace("'", "''");
                   
                    case 1:
                    text.Trim();
                    return text.Replace(" ","");
                   

                default:
                    return FixText(FixText(text,1));
                   
            }
            
        }
        /// <summary>
        /// enter event KeyPressEventArgs
        /// </summary>
        /// <param name="e"></param>
        public void whriteNumber(KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}

