﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class UrlValueExtractor
    {
        private readonly string _argumentos;
        public string URL { get; }
        public UrlValueExtractor(string url)
        {
            if(String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }            

            int interrogationIndex = url.IndexOf('?');
            _argumentos = url.Substring(interrogationIndex + 1);

            URL = url;
        }

        public string GetValueParam(string paramName)
        {
            return "";
        }
    }
}
