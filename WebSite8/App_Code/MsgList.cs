using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// MsgList 的摘要说明
/// </summary>
public class MsgList
{
    static public List<Massage> msg = new List<Massage>();
    public MsgList()
    {
        Massage msg1 = new Massage("系统消息", "快来发送第一条消息吧!");
        msg.Add(msg1);
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public static void Test()
    {
        if(msg.Count==101)                       //消息保留数量+1
        {
            for (int i = 0; i < 100; i++)        //消息保留数量
            {
                msg[i] = msg[i + 1];
            }
            msg.Remove(msg[100]);                //消息保留数量
        }
    }
}