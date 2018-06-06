using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Massage 的摘要说明
/// </summary>
public class Massage
{
    private String username;
    private String content;
    public Massage(string username,string content)
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
        this.username = username;
        this.content = content;
    }
    public Massage()
    {

    }
    public string Username { get; set; }
    public string Content { get; set; }

}