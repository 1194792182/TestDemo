using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebLog;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "<div class=\"am- gallery - item\">" +
                                        "< p style =\"text-align:center;\">" +
          "< strong style =\"color:#FF0000;font-size:18px;\">女款地址：</strong><strong style=\"color:#FF0000;font-size:18px;\"><a href=\"http://weixin.xtep.com.cn/mobile/Product/ProductDetail?productid=463\" target=\"_self\">点击进入</a></strong> " +
        "</ p >" +
        "< p style =\"text-align:center;\">" +
              "< br >" +
          "</ p >" +
          "< div class=\"J_DetailSection tshop-psm tshop-psm-bdetaildes\" id=\"description\" style=\"margin:0px;padding:0px;width:auto;color:#404040;font-family:tahoma, arial, 微软雅黑, sans-serif;white-space:normal;background-color:#FFFFFF;\">" +
    "< div class=\"content ke-post\" style=\"margin:0px;padding:0px;width:790px;height:auto;line-height:1.5;overflow:hidden;font-family:tahoma, arial, 宋体, sans-serif;font-size:14px;font-stretch:normal;\">" +
        "< p style =\"padding:0px;line-height:2.4;margin-top:0px;margin-bottom:0px;\">" +
            "< img align =\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i1/353571709/TB2uMasXWmWQ1JjSZPhXXXCJFXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i1/353571709/TB2RE.reDAKL1JjSZFCXXXFspXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i4/353571709/TB2GycAezoIL1JjSZFyXXbFBpXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i2/353571709/TB2E6creu7JL1JjSZFKXXc4KXXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i2/353571709/TB2sisBayoaPuJjSsplXXbg7XXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i4/353571709/TB2nd2nd.l7MKJjSZFDXXaOEpXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i1/353571709/TB2QKEPcDZRMeJjSspnXXcJdFXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i4/353571709/TB25XwOcrsTMeJjy1zeXXcOCVXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i1/353571709/TB2TmITcwoQMeJjy1XaXXcSsFXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i3/353571709/TB2ipsseDAKL1JjSZFCXXXFspXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i3/353571709/TB2XkZ0cwMPMeJjy1XcXXXpppXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i1/353571709/TB2vxpvcTZRMeJjSspoXXcCOFXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i4/353571709/TB2WaVvcOERMeJjy0FcXXc7opXa-353571709.jpg\" data-am-pureviewed=\"1\"><img align=\"absmiddle\" class=\"img-ks-lazyload\" style=\"\" src=\"https://img.alicdn.com/imgextra/i4/353571709/TB2_lEtd.F7MKJjSZFLXXcMBVXa-353571709.jpg\" data-am-pureviewed=\"1\"> " +
        "</p>" +
    "</div>" +
"</div>" +
"< div id =\"J_DcBottomRightWrap\" style=\"margin:0px;padding:0px;width:790px;color:#404040;overflow:hidden;font-family:tahoma, arial, 微软雅黑, sans-serif;white-space:normal;position:relative;background-color:#FFFFFF;\">" +
 "   < div class=\"J_DcAsyn tb-shop\" id=\"J_DcBottomRight\" style=\"margin:0px;padding:0px;\">" +
  "      < div class=\"J_TModule\" id=\"shop14524123776\" style=\"margin:0px;padding:0px;\" data-title=\"自定义内容区\" microscope-data=\"5003-14524123776\" data-spm=\"110.0.5003-14524123776\" data-componentid=\"5003\" data-widgetid=\"14524123776\">" +
   "         < div class=\"skin-box tb-module tshop-pbsm tshop-pbsm-shop-self-defined\" style=\"margin:0px;padding:0px;overflow:visible;font-family:微软雅黑, tahoma, arial;position:static;z-index:2;\">" +
    "            < s class=\"skin-box-tp\" style=\"margin:0px;padding:0px;\"><b style=\"margin:0px;padding:0px;\"></b></s> " +
     "           < div class=\"skin-box-bd clear-fix\" style=\"background:none;margin:0px;padding:0px;border:currentColor;border-image:none;width:790px;color:#2953A6;line-height:1.2;overflow:visible;position:static;\">" +
      "              < span style =\"margin:0px;padding:0px;\"> " +
       "             < table style =\"margin:0px auto;padding:0px;border-collapse:separate;border-spacing:0px;\" cellspacing=\"0\" cellpadding=\"0\">" +
        "                < tbody style =\"margin:0px;padding:0px;\">" +
         "                   < tr style =\"margin:0px;padding:0px;\">" +
          "                      < td style =\"margin:0px;padding:0px;\">" +
           "                         < img style =\"\" alt=\"\" src=\"https://gdp.alicdn.com/imgextra/i1/353571709/TB2uQ4XdXXXXXXxXpXXXXXXXXXX_!!353571709.jpg\" data-am-pureviewed=\"1\"> " +
            "                    </td>" +
             "               </tr>" +
              "              < tr style =\"margin:0px;padding:0px;\">" +
               "                 < td style =\"margin:0px;padding:0px;\">" +
                "                    < img style =\"\" alt=\"\" src=\"https://gdp.alicdn.com/imgextra/i2/353571709/T2oQd_Xn4XXXXXXXXX_!!353571709.jpg\" data-am-pureviewed=\"1\"> " +
                 "               </td>" +
                  "          </tr>" +
                   "     </tbody>" +
                    "</table>" +
"</span> " +
 "               </div>" +
  "          </div>" +
     "   </div>" +
    "</div>" +
"</div>" +
"< p>" +
 "   < br>" +
"</p>" +
"< p style =\"text-align:center;\">" +
 "   < br>" +
"</p>" +
 "                               </div>";

            var collection = Regex.Matches(str, @"http[s]?://[\S\s]{1,80}?.jpg");

            var list = new List<object>();
            
            foreach (var item in collection)
            {
                list.Add(item);
            }

            var result = string.Join(",", list);
            try
            {
                WebLogHelper.WebLog(result);
            }
            catch
            {
                
            }
            Console.Write(result);
        }
    }
}
