// ***********************************************************************
// Assembly         : OpenAC.Net.Sat
// Author           : RFTD
// Created          : 03-31-2016
//
// Last Modified By : RFTD
// Last Modified On : 03-31-2016
// ***********************************************************************
// <copyright file="CalcPathEventEventArgs.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Projeto OpenAC .Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace OpenAC.Net.Sat.Events
{
    /// <summary>
    /// Class CalcPathEventEventArgs.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public sealed class CalcPathEventEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets the dados.
        /// </summary>
        /// <value>The dados.</value>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the retorno.
        /// </summary>
        /// <value>The retorno.</value>
        public string CNPJ { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The data.</value>
        public DateTime Data { get; set; }
    }
}