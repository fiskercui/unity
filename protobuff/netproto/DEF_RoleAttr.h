#ifndef DEF_ROLEATTR_H
#define DEF_ROLEATTR_H
/**角色属性**/
enum DEF_RoleAttr {
/**体力**/
	ROLE_ATTR_POWER = 1 ,
/**精力**/
	ROLE_ATTR_ENERGY = 2 ,
/**元宝**/
	ROLE_ATTR_YUEN_BAO = 3 ,
/**银两**/
	ROLE_ATTR_SILVER = 4 ,
/**将魂**/
	ROLE_ATTR_HERO_SOUL = 5 ,
/**神魂**/
	ROLE_ATTR_GOD_SOUL = 6 ,
/**兽魂**/
	ROLE_ATTR_BEAST_SOUL = 7 ,
/**灵玉**/
	ROLE_ATTR_JADE = 8 ,
/**军团贡献**/
	ROLE_ATTR_DEVOTE = 9 ,
/**竞技场声望**/
	ROLE_ATTR_PRESTIGE = 10 ,
/**威名**/
	ROLE_ATTR_WAL_MART = 11 ,
/**战功**/
	ROLE_ATTR_MILITARY_EXPLOITS = 12 ,
/**演武勋章**/
	ROLE_ATTR_MEDAL = 13 ,
/**虎牢积分**/
	ROLE_ATTR_SCORE = 14 ,
/**征讨令**/
	ROLE_ATTR_CRUSADE = 15 ,
/**等级**/
	ROLE_ATTR_LEVEL = 16 ,
/**VIP等级**/
	ROLE_ATTR_VIPLEVEL = 17 ,
/**拥有阵容位**/
	ROLE_ATTR_ZHENGRONG = 18 ,
/**拥有援军位**/
	ROLE_ATTR_YUANJUN = 19 ,
/**战斗力**/
	ROLE_ATTR_FIGHT_POWER = 20 ,
/**经验值**/
	ROLE_ATTR_EXP = 21 ,
/**大黄庭**/
	ROLE_ATTR_HUANGTING = 22 ,
/**吃黄瓜时间戳**/
	ROLE_EAT_CUCUMBER = 23 ,
/**体力恢复时间戳**/
	ROLE_ATTR_POWER_TS = 24 ,
/**精力恢复时间戳**/
	ROLE_ATTR_ENERGY_TS = 25 ,
/**征讨令恢复时间戳**/
	ROLE_ATTR_CRUSADE_TS = 26 ,
/**新手引导索引**/
	ROLE_ATTR_GUILD_IDX = 27 ,
/**名次副本当天打的次数**/
	ROLE_ATTR_FAMOUS_RAID_COUNT = 28 ,
/**当天领取好友精力次数**/
	ROLE_ATTR_RECV_FRIEND_ENERGY = 29 ,
/**VIP积分**/
	ROLE_ATTR_VIP_SCORE = 30 ,
/**每日福利领取的VIP等级**/
	ROLE_ATTR_VIP_DAILY_WELFARE = 31 ,
/**当天祭天方式**/
	ROLE_ATTR_WORSHIP_ID = 32 ,
/**当天祭天开箱情况, 按位运算**/
	ROLE_ATTR_WORSHIP_BOX = 33 ,
/**当天帮派贡献**/
	ROLE_ATTR_TODAY_DEVOTE = 34 ,
/**经验加成**/
	ROLE_ATTR_EXPRATE = 35 ,
/**当天寻访好友加速次数**/
	ROLE_ATTR_ACCELERATE_COUNT = 36 ,
/**当天获取寻访钱袋次数**/
	ROLE_ATTR_VISIT_REWARD_COUNT = 37 ,
/**历史最高战力**/
	ROLE_ATTR_HISTORY_FIGHT_POWER = 38 ,
/**首充送礼状态, 0: 充值, 1: 领取, 2: 已领**/
	ROLE_ATTR_FIRST_RECHARGE_AWARD = 39 ,
/**今日充值金额**/
	ROLE_ATTR_TODAY_RECHARGE = 40 ,
/**侠义**/
	ROLE_ATTR_XIAYI = 41 ,
/**阅历**/
	ROLE_ATTR_YUELI = 42 ,
/**跨服积分赛挑战次数**/
	ROLE_ATTR_CSPOINTSRACE_CNT = 43 ,
/**跨服积分赛挑战次数恢复时间戳**/
	ROLE_ATTR_CSPOINTSRACE_CNT_TS = 44 ,
/**跨服积分赛荣誉点**/
	ROLE_ATTR_CSPOINTSRACE_HONOR = 45 ,
/**最大主角属性**/
	ROLE_ATTR_MAX = 46 ,
};
#endif