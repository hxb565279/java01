package com.hxb.instance.annotation.dao;


import org.springframework.stereotype.Controller;

import javax.annotation.Resource;

@Controller("userController")
public class UserController {
  @Resource(name = "userService")
    private UserService userService;
  public void  save(){
      this.userService.save();
      System.out.println("执行陈宫");
  }


}
