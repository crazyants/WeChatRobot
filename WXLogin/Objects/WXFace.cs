﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WXLogin
{
    public static class WXFace
    {
        public static readonly Dictionary<string, string> Face = new Dictionary<string, string>
        {
            {"微笑", "0"},
            {"撇嘴", "1"},
            {"色", "2"},
            {"发呆", "3"},
            {"得意", "4"},
            {"流泪", "5"},
            {"害羞", "6"},
            {"闭嘴", "7"},
            {"睡", "8"},
            {"大哭", "9"},
            {"尴尬", "10"},
            {"发怒", "11"},
            {"调皮", "12"},
            {"呲牙", "13"},
            {"惊讶", "14"},
            {"难过", "15"},
            {"酷", "16"},
            {"冷汗", "17"},
            {"抓狂", "18"},
            {"吐", "19"},
            {"偷笑", "20"},
            {"可爱", "21"},
            {"愉快", "21"},
            {"白眼", "22"},
            {"傲慢", "23"},
            {"饥饿", "24"},
            {"困", "25"},
            {"惊恐", "26"},
            {"流汗", "27"},
            {"憨笑", "28"},
            {"悠闲", "29"},
            {"大兵", "29"},
            {"奋斗", "30"},
            {"咒骂", "31"},
            {"疑问", "32"},
            {"嘘", "33"},
            {"晕", "34"},
            {"疯了", "35"},
            {"折磨", "35"},
            {"衰", "36"},
            {"骷髅", "37"},
            {"敲打", "38"},
            {"再见", "39"},
            {"擦汗", "40"},
            {"抠鼻", "41"},
            {"鼓掌", "42"},
            {"糗大了", "43"},
            {"坏笑", "44"},
            {"左哼哼", "45"},
            {"右哼哼", "46"},
            {"哈欠", "47"},
            {"鄙视", "48"},
            {"委屈", "49"},
            {"快哭了", "50"},
            {"阴险", "51"},
            {"亲亲", "52"},
            {"吓", "53"},
            {"可怜", "54"},
            {"菜刀", "55"},
            {"西瓜", "56"},
            {"啤酒", "57"},
            {"篮球", "58"},
            {"乒乓", "59"},
            {"咖啡", "60"},
            {"饭", "61"},
            {"猪头", "62"},
            {"玫瑰", "63"},
            {"凋谢", "64"},
            {"嘴唇", "65"},
            {"示爱", "65"},
            {"爱心", "66"},
            {"心碎", "67"},
            {"蛋糕", "68"},
            {"闪电", "69"},
            {"炸弹", "70"},
            {"刀", "71"},
            {"足球", "72"},
            {"瓢虫", "73"},
            {"便便", "74"},
            {"月亮", "75"},
            {"太阳", "76"},
            {"礼物", "77"},
            {"拥抱", "78"},
            {"强", "79"},
            {"弱", "80"},
            {"握手", "81"},
            {"胜利", "82"},
            {"抱拳", "83"},
            {"勾引", "84"},
            {"拳头", "85"},
            {"差劲", "86"},
            {"爱你", "87"},
            {"NO", "88"},
            {"OK", "89"},
            {"爱情", "90"},
            {"飞吻", "91"},
            {"跳跳", "92"},
            {"发抖", "93"},
            {"怄火", "94"},
            {"转圈", "95"},
            {"磕头", "96"},
            {"回头", "97"},
            {"跳绳", "98"},
            {"投降", "99"},
            {"激动", "100"},
            {"乱舞", "101"},
            {"献吻", "102"},
            {"左太极", "103"},
            {"右太极", "104"},
            {"嘿哈", "105"},
            {"捂脸", "106"},
            {"奸笑", "107"},
            {"机智", "108"},
            {"皱眉", "109"},
            {"耶", "110"},
            {"鸡", "111"},
            {"红包", "112"},
            {"1f604","<笑脸>"},
            {"1f60a","<开心>"},
            {"1f603","<大笑>"},
            {"263a","<热情>"},
            {"1f609","<眨眼>"},
            {"1f60d","<色>"},
            {"1f618","<接吻>"},
            {"1f61a","<亲吻>"},
            {"1f633","<脸红>"},
            {"1f63c","<露齿笑>"},
            {"1f60c","<满意>"},
            {"1f61c","<戏弄>"},
            {"1f445","<吐舌>"},
            {"1f612","<无语>"},
            {"1f60f","<得意>"},
            {"1f613","<汗>"},
            {"1f640","<失望>"},
            {"1f64f","<合十>"},
            {"1f61e","<低落>"},
            {"1f616","<呸>"},
            {"1f625","<焦虑>"},
            {"1f630","<担心>"},
            {"1f628","<震惊>"},
            {"1f62b","<悔恨>"},
            {"1f622","<眼泪>"},
            {"1f62d","<哭>"},
            {"1f602","<破涕为笑>"},
            {"1f632","<晕>"},
            {"1f631","<恐惧>"},
            {"1f620","<心烦>"},
            {"1f63e","<生气>"},
            {"1f62a","<睡觉>"},
            {"1f637","<生病>"},
            {"1f47f","<恶魔>"},
            {"1f47d","<外星人>"},
            {"2764","<心>"},
            {"1f494","<心碎>"},
            {"1f498","<丘比特>"},
            {"2728","<闪烁>"},
            {"1f31f","<星星>"},
            {"2755","<叹号>"},
            {"2754","<问号>"},
            {"1f4a4","<睡着>"},
            {"1f4a6","<水滴>"},
            {"1f3b5","<音乐>"},
            {"1f525","<火>"},
            {"1f4a9","<便便>"},
            {"1f44d","<强>"},
            {"1f44e","<弱>"},
            {"1f44a","<拳头>"},
            {"270c","<胜利>"},
            {"1f446","<上>"},
            {"1f447","<下>"},
            {"1f449","<右>"},
            {"1f448","<左>"},
            {"261d","<第一>"},
            {"1f4aa","<强壮>"},
            {"1f48f","<吻>"},
            {"1f491","<热恋>"},
            {"1f466","<男孩>"},
            {"1f467","<女孩>"},
            {"1f469","<女士>"},
            {"1f468","<男士>"},
            {"1f47c","<天使>"},
            {"1f480","<骷髅>"},
            {"1f48b","<红唇>"},
            {"2600","<太阳>"},
            {"2614","<下雨>"},
            {"2601","<多云>"},
            {"26c4","<雪人>"},
            {"1f319","<月亮>"},
            {"26a1","<闪电>"},
            {"1f30a","<海浪>"},
            {"1f431","<猫>"},
            {"1f429","<小狗>"},
            {"1f42d","<老鼠>"},
            {"1f439","<仓鼠>"},
            {"1f430","<兔子>"},
            {"1f43a","<狗>"},
            {"1f438","<青蛙>"},
            {"1f42f","<老虎>"},
            {"1f428","<考拉>"},
            {"1f43b","<熊>"},
            {"1f437","<猪>"},
            {"1f42e","<牛>"},
            {"1f417","<野猪>"},
            {"1f435","<猴子>"},
            {"1f434","<马>"},
            {"1f40d","<蛇>"},
            {"1f426","<鸽子>"},
            {"1f414","<鸡>"},
            {"1f427","<企鹅>"},
            {"1f41b","<毛虫>"},
            {"1f419","<章鱼>"},
            {"1f420","<鱼>"},
            {"1f433","<鲸鱼>"},
            {"1f42c","<海豚>"},
            {"1f339","<玫瑰>"},
            {"1f33a","<花>"},
            {"1f334","<棕榈树>"},
            {"1f335","<仙人掌>"},
            {"1f49d","<礼盒>"},
            {"1f383","<南瓜灯>"},
            {"1f47b","<鬼魂>"},
            {"1f385","<圣诞老人>"},
            {"1f384","<圣诞树>"},
            {"1f381","<礼物>"},
            {"1f514","<铃>"},
            {"1f389","<庆祝>"},
            {"1f388","<气球>"},
            {"1f4bf","<CD>"},
            {"1f4f7","<相机>"},
            {"1f3a5","<录像机>"},
            {"1f4bb","<电脑>"},
            {"1f4fa","<电视>"},
            {"1f4de","<电话>"},
            {"1f513","<解锁>"},
            {"1f512","<锁>"},
            {"1f511","<钥匙>"},
            {"1f528","<成交>"},
            {"1f4a1","<灯泡>"},
            {"1f4eb","<邮箱>"},
            {"1f6c0","<浴缸>"},
            {"1f4b2","<钱>"},
            {"1f4a3","<炸弹>"},
            {"1f52b","<手枪>"},
            {"1f48a","<药丸>"},
            {"1f3c8","<橄榄球>"},
            {"1f3c0","<篮球>"},
            {"26bd","<足球>"},
            {"26be","<棒球>"},
            {"26f3","<高尔夫>"},
            {"1f3c6","<奖杯>"},
            {"1f47e","<入侵者>"},
            {"1f3a4","<唱歌>"},
            {"1f3b8","<吉他>"},
            {"1f459","<比基尼>"},
            {"1f451","<皇冠>"},
            {"1f302","<雨伞>"},
            {"1f45c","<手提包>"},
            {"1f484","<口红>"},
            {"1f48d","<戒指>"},
            {"1f48e","<钻石>"},
            {"2615","<咖啡>"},
            {"1f37a","<啤酒>"},
            {"1f37b","<干杯>"},
            {"1f377","<鸡尾酒>"},
            {"1f354","<汉堡>"},
            {"1f35f","<薯条>"},
            {"1f35d","<意面>"},
            {"1f363","<寿司>"},
            {"1f35c","<面条>"},
            {"1f373","<煎蛋>"},
            {"1f366","<冰激凌>"},
            {"1f382","<蛋糕>"},
            {"1f34f","<苹果>"},
            {"2708","<飞机>"},
            {"1f680","<火箭>"},
            {"1f6b2","<自行车>"},
            {"1f684","<高铁>"},
            {"26a0","<警告>"},
            {"1f3c1","<旗>"},
            {"1f6b9","<男人>"},
            {"1f6ba","<女人>"},
            {"2b55","<O>"},
            {"274e","<X>"},
            {"a9","<版权>"},
            {"ae","<注册商标>"},
            {"2122","<商标>"}
        };
    }
}
