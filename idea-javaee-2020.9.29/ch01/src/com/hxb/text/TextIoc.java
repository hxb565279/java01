package com.hxb.text;

import com.hxb.dao.UserDao;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class TextIoc {
    public static void main(String[] args) {
        ApplicationContext applicationContext = new ClassPathXmlApplicationContext("applicationContext.xml");
        UserDao userDao =  (UserDao)  applicationContext.getBean("userDao");
       userDao.say();
    }
}
