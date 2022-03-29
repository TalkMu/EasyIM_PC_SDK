using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyIMApp.VO
{
    internal class LoginVO
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required(ErrorMessage = "用户名不能为空")]
        [MaxLength(16, ErrorMessage = "用户名最多为10位")]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "密码不能为空")]
        [MaxLength(16, ErrorMessage = "用户名最多为18位")]
        public string Password { get; set; }
    }
}
