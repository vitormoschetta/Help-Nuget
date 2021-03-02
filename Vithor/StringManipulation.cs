using System;
using System.Collections.Generic;

namespace Vithor
{
    /// <summary>
    /// Manipula strings e lista de strings
    /// </summary>
    public class StringManipulation
    {
        /// <summary>
        /// Agrupa uma lista de string 
        /// </summary>           
        /// <param name="list">Uma lista de string</param>
        /// <param name="separator">Caractere separador de itens</param>
        /// <returns>
        /// Retorna uma string (o agrupamento de uma lista de string)
        /// </returns>       
        public static string GroupStringList(List<string> list, string separator)
        {
            return string.Join(separator, list);
        }


        /// <summary>
        /// Agrupa um array de string
        /// </summary>           
        /// <param name="list">Um array de string</param>
        /// <param name="separator">Caractere separador de itens</param>
        /// <returns>
        /// Retorna uma string (o agrupamento de um array de string)
        /// </returns>     
        public static string GroupStringList(string[] list, string separator)
        {
            return string.Join(separator, list);
        }
        
    }
}
