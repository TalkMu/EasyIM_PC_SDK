using System;
using System.Collections.Generic;
using System.Text;

namespace EasyIM_PC_SDK.Response
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  ApiResult 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2022/3/3 14:45:43 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/3 14:45:43 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class ApiResult<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public bool Flag { get; set; }
        public T Data { get; set; }
    }
}
