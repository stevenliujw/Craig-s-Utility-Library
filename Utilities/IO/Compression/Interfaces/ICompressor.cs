﻿/*
Copyright (c) 2013 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Utilities.IO.Messaging.BaseClasses;
using Utilities.IO.Messaging.Interfaces;
using Utilities.DataTypes;
#endregion

namespace Utilities.IO.Compression.Interfaces
{
    /// <summary>
    /// Compressor interface
    /// </summary>
    public interface ICompressor
    {
        /// <summary>
        /// Compressor name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Compresses the byte array
        /// </summary>
        /// <param name="Data">Data to compress</param>
        /// <returns>Compressed data</returns>
        byte[] Compress(byte[] Data);

        /// <summary>
        /// Decompresses the data
        /// </summary>
        /// <param name="Data">Data to decompress</param>
        /// <returns>The decompressed data</returns>
        byte[] Decompress(byte[] Data);
    }
}