<?php
session_start();
header('Content-type:text/html;charset=utf-8');
if(isset($_SESSION['c_name']) ){
    session_unset();
    session_destroy();
    setcookie(session_name(),'',time()-3600);
    header('location:skip.php?url=index.php&info=注销成功，正在跳转！');
}else{
    header('location:skip.php?url=index.php&info=注销失败，稍后重试！');
}