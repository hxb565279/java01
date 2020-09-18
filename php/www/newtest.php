<?php
	echo "<meta charset='utf-8'>";
	// echo PHP_VERSION;
	$link=mysql_connect('localhost','root','123')
	or die("<script>alert('数据库连接失败')</script>");
	mysql_set_charset('utf8');
	// var_dump($link);die;
	$select=mysql_select_db("php")
	or die("<script>alert('选择失败')</script>");
	$sql='select * from student';
	$query=mysql_query($sql)
	or die("<script>alert('查询失败，请重试！');</script>");
	$insert_sql='insert into classes values(default,"PHP","王五")';
	//var_dump($insert_sql);
	//mysql_query($insert_sql);
	$update_sql="update classes set name='嵌入式原理',teacher='露露' where id=5";
	$delete_sql=="delete from classes where id=6";
	$selete_sql='select * from classes';
	$query=mysql_query($selete_sql);
	//var_dump($result);
	echo "<pre>";
	//print_r(mysql_fetch_row($result));
	//echo mysql_num_rows($result);
	while ($result=mysqli_fetch_array($query,MYSQL_ASSOC)) {
		print_r($result);
	}
	//print_r(mysql_fetch_array($result,MYSQL_ASSOC));
	//var_dump(mysql_fetch_object($result));

?>