<?php
$conn = mysqli_connect('localhost','root','123456','php');
if (!$conn){
    echo "连接失败";
}
session_start();
mysqli_set_charset($conn,'utf8');
 $result=  $conn->query("select * from db_news where n_type = 12");
while ( $news=mysqli_fetch_array($result,MYSQLI_ASSOC)){
    $_SESSION['title']=$news['n_title'];
}


$conn = mysqli_connect('localhost','root','123456','php');
if (!$conn){
    echo "连接失败";
}
mysqli_set_charset($conn,'utf8');
$result=  $conn->query("select * from db_news where n_type = 12");
while ( $news=mysqli_fetch_array($result,MYSQLI_ASSOC)){
    $_SESSION['title']=$news['n_title'];
}





$conn = mysqli_connect('localhost','root','123456','php');
if (!$conn){
    echo "连接失败";
}
mysqli_set_charset($conn,'utf8');
$result=  $conn->query("select * from db_news where n_type = 12");
while ( $news=mysqli_fetch_array($result,MYSQLI_ASSOC)){
    $_SESSION['title']=$news['n_title'];
}

