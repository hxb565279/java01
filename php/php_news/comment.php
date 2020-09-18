<?php
@$connect = mysqli_connect('localhost', 'root', '123456');
mysql_set_charset('utf8','$connect',);
if (!$connect) {
    die('数据库连接失败！ ' . mysql_error());
}
$link=mysql_select_db('php', $connect) ;
if (!$link){
    die('无法连接think表 : ' . mysql_error());
}
session_start();
$time=time();

$sql="INSERT INTO 
      db_comment
      (co_news_id, co_message, co_customer_id,co_status,co_addtime) 
      VALUES
      ('".$_POST['n_id']."','". $_POST['co_message']."','". $_SESSION['c_id']."','1',$time)";
$result=mysql_query($sql);
if($result){
    $message['flag']=1;
    echo json_encode($message);
}


?>