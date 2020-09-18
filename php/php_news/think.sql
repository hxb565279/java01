/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50710
Source Host           : localhost:3306
Source Database       : think

Target Server Type    : MYSQL
Target Server Version : 50710
File Encoding         : 65001

Date: 2017-01-11 12:56:50
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for db_ad
-- ----------------------------
DROP TABLE IF EXISTS `db_ad`;
CREATE TABLE `db_ad` (
  `a_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '广告表主键',
  `a_name` varchar(50) DEFAULT NULL COMMENT '广告名称',
  `a_pic` varchar(255) DEFAULT NULL COMMENT '广告图片',
  `a_describe` varchar(255) DEFAULT NULL COMMENT '广告描述',
  `a_link` varchar(50) DEFAULT NULL COMMENT '链接地址',
  `a_order` int(11) DEFAULT NULL COMMENT '排序',
  `a_status` tinyint(4) DEFAULT NULL COMMENT '广告状态 0关闭，1开启',
  `a_position` varchar(6) DEFAULT '' COMMENT '广告放置位置,1:左侧悬浮窗，2：右侧悬浮，3友情链接',
  PRIMARY KEY (`a_id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_ad
-- ----------------------------
INSERT INTO `db_ad` VALUES ('1', '蒙牛牛奶', 'ad_1458876558.png', '蒙牛牛奶很好喝', 'http://www.mengniu.com.cn/', '1', '1', '1');
INSERT INTO `db_ad` VALUES ('4', '测试', 'ad_1458889624.png', '测试', '测试1111', '1', '1', '3');
INSERT INTO `db_ad` VALUES ('5', '测试2', 'ad_1458889624.png', '测试2', '测试22222', '2', '1', '3');
INSERT INTO `db_ad` VALUES ('6', '蒙牛牛奶', 'ad_1458889624.png', '蒙牛牛奶很好喝', 'http://www.mengniu.com.cn/', '1', '1', '1');
INSERT INTO `db_ad` VALUES ('7', '新闻中心', 'ad_1459923436.jpg', '蒙牛牛奶很好喝', 'http://www.mengniu.com.cn/', '1', '1', '2');

-- ----------------------------
-- Table structure for db_comment
-- ----------------------------
DROP TABLE IF EXISTS `db_comment`;
CREATE TABLE `db_comment` (
  `co_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '评论表主键',
  `co_news_id` int(11) DEFAULT NULL COMMENT '被评论新闻id',
  `co_customer_id` int(11) DEFAULT NULL COMMENT '评论用户id',
  `co_message` mediumtext COMMENT '评论内容',
  `co_status` tinyint(4) DEFAULT NULL COMMENT '评论状态 0为关闭，1为开启',
  `co_addtime` varchar(255) DEFAULT NULL COMMENT '评论发表时间',
  PRIMARY KEY (`co_id`)
) ENGINE=MyISAM AUTO_INCREMENT=64 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_comment
-- ----------------------------
INSERT INTO `db_comment` VALUES ('63', '29', '11', '123', '0', '1462845793');
INSERT INTO `db_comment` VALUES ('55', '13', '11', '测试一下', '1', '1462346344');
INSERT INTO `db_comment` VALUES ('56', '14', '11', '123', '1', '1462435669');
INSERT INTO `db_comment` VALUES ('57', '14', '11', '44444444', '1', '1462435681');
INSERT INTO `db_comment` VALUES ('59', '14', '11', '1', '1', '1462436466');
INSERT INTO `db_comment` VALUES ('60', '14', '11', '2', '1', '1462436469');
INSERT INTO `db_comment` VALUES ('61', '14', '11', '2', '1', '1462436471');

-- ----------------------------
-- Table structure for db_customer
-- ----------------------------
DROP TABLE IF EXISTS `db_customer`;
CREATE TABLE `db_customer` (
  `c_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '用户表主键',
  `c_name` varchar(50) DEFAULT NULL COMMENT '用户名称',
  `c_password` varchar(50) DEFAULT NULL COMMENT '用户密码',
  `c_status` tinyint(4) DEFAULT NULL COMMENT '用户状态 0：禁言，1：正常',
  `c_register_time` varchar(255) DEFAULT NULL COMMENT '注册时间',
  `c_email` varchar(50) DEFAULT NULL COMMENT '用户邮箱',
  PRIMARY KEY (`c_id`)
) ENGINE=MyISAM AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_customer
-- ----------------------------
INSERT INTO `db_customer` VALUES ('11', 'doom', 'b4f945433ea4c369c12741f62a23ccc0', '1', '1459842886', 'doom@126.com');
INSERT INTO `db_customer` VALUES ('13', 'jugg', 'cf3a6f91a31f6b0d7b397dad7143e1e4', '1', '1461047830', 'jugg@126.com');
INSERT INTO `db_customer` VALUES ('14', 'coco', 'ac0ddf9e65d57b6a56b2453386cd5db5', '1', '1461119275', 'coco@126.com');
INSERT INTO `db_customer` VALUES ('17', 'nec', '0490b305539f9a2d4fb47a454c3a0dda', '1', '1461207274', 'nec@126.com');
INSERT INTO `db_customer` VALUES ('28', '1', 'd41d8cd98f00b204e9800998ecf8427e', '1', '1461919157', '1');
INSERT INTO `db_customer` VALUES ('31', '林林', '202cb962ac59075b964b07152d234b70', '1', '1462953502', '123');
INSERT INTO `db_customer` VALUES ('32', '12', 'c20ad4d76fe97759aa27a0c99bff6710', '1', '1466063190', '12');
INSERT INTO `db_customer` VALUES ('33', '123', 'c4ca4238a0b923820dcc509a6f75849b', '1', '1466063294', '1');

-- ----------------------------
-- Table structure for db_news
-- ----------------------------
DROP TABLE IF EXISTS `db_news`;
CREATE TABLE `db_news` (
  `n_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '新闻主键',
  `n_title` varchar(150) DEFAULT NULL COMMENT '新闻标题',
  `n_message` mediumtext COMMENT '新闻内容',
  `n_addtime` varchar(50) DEFAULT NULL COMMENT '发布时间',
  `n_type` varchar(50) DEFAULT NULL COMMENT '新闻分类',
  `n_status` tinyint(4) DEFAULT NULL COMMENT '新闻状态 0关闭，1开启',
  `n_author` varchar(50) DEFAULT NULL COMMENT '作者',
  `n_nums` varchar(50) DEFAULT '0' COMMENT '阅读次数',
  `n_picture` varchar(50) DEFAULT NULL COMMENT '新闻图片',
  PRIMARY KEY (`n_id`)
) ENGINE=MyISAM AUTO_INCREMENT=106 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_news
-- ----------------------------
INSERT INTO `db_news` VALUES ('13', '测试新闻1', '测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内测试新闻2的新闻内', '1458799075', '13', '1', '1', '10', '');
INSERT INTO `db_news` VALUES ('5', '测试新闻2', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '10', null);
INSERT INTO `db_news` VALUES ('14', '测试新闻3', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '55', '');
INSERT INTO `db_news` VALUES ('7', '测试新闻31', '测试4441', '1458799073', '13', '1', '1', '1', null);
INSERT INTO `db_news` VALUES ('12', '测试新闻4', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '1', '');
INSERT INTO `db_news` VALUES ('18', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('15', '测试新闻5', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '1', '');
INSERT INTO `db_news` VALUES ('16', '测试新闻6', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('17', '测试新闻7', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '1', '');
INSERT INTO `db_news` VALUES ('19', '测试新闻5', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('20', '测试新闻7', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('21', '测试新闻6', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('22', '测试新闻8', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('23', '测试新闻9', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('24', '测试新闻10', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '1', '');
INSERT INTO `db_news` VALUES ('25', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('26', '测试新闻11', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('27', '测试新闻4', '测试4441', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('28', '测试新闻12', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('29', '测试新13', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '2', '');
INSERT INTO `db_news` VALUES ('30', '测试新闻14', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('31', '测试新闻15', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('32', '测试新闻16', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('33', '测试新闻17', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('34', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('35', '测试新闻5', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '2', '');
INSERT INTO `db_news` VALUES ('36', '测试新闻7', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('37', '测试新闻6', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('38', '测试新闻18', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('39', '测试新闻19', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('40', '测试新闻20', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('41', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('42', '测试新闻21', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('43', '测试新闻4', '测试4441', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('44', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('45', '测试新闻23', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('46', '测试新闻24', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('47', '测试新闻25', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('48', '测试新闻26', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('49', '测试新闻27', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('50', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('51', '测试新闻5', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('52', '测试新闻7', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('53', '测试新闻6', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('54', '测试新闻28', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('55', '测试新闻29', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('56', '测试新闻30', '测试新闻2的新闻内', '1458799075', '13', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('57', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '5', '');
INSERT INTO `db_news` VALUES ('58', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('59', '测试新闻5', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('60', '测试新闻7', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('61', '测试新闻6', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('62', '测试新闻5', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('63', '测试新闻6', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('64', '测试新闻7', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('65', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('66', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('67', '测试新闻5', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('68', '测试新闻7', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('69', '测试新闻6', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('70', '测试新闻5', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('71', '测试新闻6', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('72', '测试新闻7', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('73', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('74', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('75', '测试新闻5', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('76', '测试新闻7', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('77', '测试新闻6', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('78', '测试新闻5', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('79', '测试新闻6', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('80', '测试新闻7', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('81', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('82', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '12', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('83', '测试新闻5', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('84', '测试新闻7', '测试新闻2的新闻内', '1458799075', '15', '0', '1', '0', '');
INSERT INTO `db_news` VALUES ('85', '测试新闻6', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('86', '测试新闻5', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('87', '测试新闻6', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('88', '测试新闻7', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('89', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '15', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('90', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('91', '测试新闻5', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('92', '测试新闻7', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('93', '测试新闻6', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('94', '测试新闻5', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '1', '');
INSERT INTO `db_news` VALUES ('95', '测试新闻6', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('96', '测试新闻7', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('97', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('98', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('99', '测试新闻5', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('100', '测试新闻7', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('101', '测试新闻6', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('102', '测试新闻5', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('103', '测试新闻6', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('104', '测试新闻22222', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');
INSERT INTO `db_news` VALUES ('105', '测试新闻7', '测试新闻2的新闻内', '1458799075', '14', '1', '1', '0', '');

-- ----------------------------
-- Table structure for db_type
-- ----------------------------
DROP TABLE IF EXISTS `db_type`;
CREATE TABLE `db_type` (
  `t_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '新闻分类主键',
  `t_name` varchar(50) DEFAULT NULL COMMENT '分类名称',
  `t_order` int(255) DEFAULT NULL COMMENT '分类排序',
  `t_status` tinyint(4) DEFAULT NULL COMMENT '分类状态 0关闭，1开启',
  PRIMARY KEY (`t_id`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_type
-- ----------------------------
INSERT INTO `db_type` VALUES ('12', '体育新闻', '5', '1');
INSERT INTO `db_type` VALUES ('13', '时政新闻', '1', '1');
INSERT INTO `db_type` VALUES ('14', '国际新闻', '11', '1');
INSERT INTO `db_type` VALUES ('15', '娱乐新闻', '4', '1');

-- ----------------------------
-- Table structure for db_user
-- ----------------------------
DROP TABLE IF EXISTS `db_user`;
CREATE TABLE `db_user` (
  `u_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '管理员表主键',
  `u_name` varchar(50) DEFAULT NULL COMMENT '管理员名称',
  `u_password` varchar(50) DEFAULT NULL COMMENT '管理员密码',
  `u_retime` varchar(255) DEFAULT NULL COMMENT '管理员账户创建时间',
  PRIMARY KEY (`u_id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of db_user
-- ----------------------------
INSERT INTO `db_user` VALUES ('1', 'admin', '21232f297a57a5a743894a0e4a801fc3', '0');
INSERT INTO `db_user` VALUES ('2', 'test', '098f6bcd4621d373cade4e832627b4f6', '0');
INSERT INTO `db_user` VALUES ('3', 'test2', 'ad0234829205b9033196ba818f7a872b', '1458088599');
