﻿using UnityEngine;
using System.Collections;

public enum Tai{
	SHEQU,
	TAIK,
	EDU
}

public static class commonS {

	public static bool[] result = {false,false,false};

    public static int ScreenWidth;
    public static int ScreenHeight;

    public static int normalButtonWidth = 200;
    public static int normalButtonHeight = 100;

    public static int scrollWidth = 400;
    public static int scrollHeight = 500;

    public static string info = "点个按钮看看,点个图标看看。";

	public static string finish = "哇，你已经成功认识了泰斗。";

    public static string info_shequ = "泰斗社区包含游戏开发，移动开发，互联网技术相关内容。" +
       " 在这里每一个开发者都可以找到自己想要的资源，unity3d教程、unity3d视频、unity3d插件源码、整套游戏源码，素材等。" +
        "我们在免费网校（taidous.com/free）的基础上，独创了“带你学”这种免费的网上教学模式，我们把这种教学称作：橙课 。" +
        "通过报名橙课，大家除了自主完成一系列的学习任务外，还有每周一到两个晚上的直播教学活动，每次橙课两个星期左右，而整个过程都有是老师引导的，" +
        "所以叫带你学。而且是免费的哦！橙课标志着网络免费教学也可以有很高的品质。";

    public static string info_edu = 
    "泰课学院是一家IT技术网络培训学院，专注教育内容、服务产品开发，以顶尖的教学内容，优秀的网络教学管理为核心价值。" +
    "泰课学院开启前所未有的仿真教学模式，教学过程完全采用一线公司内部培训的方式，5年以上一线主程担任主讲老师，也是国内唯一真正做到采用自主研发的大型商业项目进行实战教学的机构。独创有在线小分队、网络就业班、网络商业实战班，提供高品质的在线课程及教学服务。全网独创广邀大牛一章一节监督评价，教学过程采用商业级实战项目，一线主程一陪到底。" +
    "泰课以优质的培训服务，高质量的就业学员赢得极佳的网络口碑。" +
    "泰课出品有国内唯一的NGUI，uGUI中文视频课程、炉石传说公开课，已经分别拥有学员累积订阅上万份。" +
    "泰课出品unity3d最具网络口碑的史诗级ARPG课程《泰斗破坏神》已经累积销售上千份（由于良好的口碑反馈，《泰斗破坏神2》也于2015年底发布）。";

    public static string info_tak = "互联网技术在线教育社区——泰课在线（www.taikr.com）创办于2013年10月，是上海煌拓网络科技有限公司旗下在线教育品牌，是最早开拓IT在线教育的社区型教学平台。目前网站基于在线课程，公开课，网络实训班，泰斗训练营，在线题库等产品，提供高品质的在线课程及教学服务。" +
    "目前泰课的教学以移动应用开发、游戏开发课程为核心，主要面向立志投身互联网技术开发的朋友，或者以自我提升或就业为目标的求学人员。通过优质的视频课程、直播教学、网络组队项目实战、网络班级管理、线上教学社区等教学方式，为用户提供便捷（不受时空限制，更自由的学习时间安排，全国各地网络教学）、专业的网络教学课程与服务。" +
    "泰课在线的合作伙伴单位： 阿里云，UCloud，七牛云，开源力量，好知网";
}
