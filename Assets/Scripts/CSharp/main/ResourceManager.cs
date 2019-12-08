using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace ShuaiFramework
{
    //资源管理器
    //[LuaCallCSharp]
    public class ResourceManager
    {
        //加载sprite资源
        public static Sprite LoadAssets(string path)
        {
            return Resources.Load<Sprite>(path);
        
        }
        
    }
}