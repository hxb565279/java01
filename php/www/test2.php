<?php
/*body {background: url(/happytime/img/index.jpg) no-repeat center center fixed; 
background-size: 100%;//此处要注意，可以填cover也可以填100%。建议填100%
}*/
	$i=7;
	$sum=0;
	$ZERO=0;
	while ( $i<= 23) {
		$sum=$sum+$i;
		$i++;
	}
	echo $sum.'<br>';
	$i=7;
	$sum=0;
	do{
		$sum=$sum+$i;
		$i++;
	}while($i<=23);
	echo $sum.'<br>';
	$sum=0;
	for ($j=7; $j <24 ; $j++) { 
		$sum=$j+$sum;
	}
	echo $sum.'<br><hr>';
	$color1="red";
	$color2="blue";
	$color2.=$color1;
	$color2="red";
	$color3=$color1.$color2;

	echo "$color2<br>";
	var_dump($color2);
	
	echo "$color3<br>";
	
	$x=3;
	$y=5;
	$z=1;
	$t=2;
	$t+=$x;
	echo "$t<br>";
	echo '此时$t的值为5'."<br>";
	$t-=$z;
	echo "$t<br>";
	echo '此时$t的值为4'."<br>";
	$t*=$x;
	echo "$t<br>";
	echo '此时$t的值为12'."<br>";
	$t/=$x;
	echo "$t<br>";
	echo '此时$t的值为4'."<br>";
	$bool= false;
	var_dump($bool);
	$int1=(int)$bool;
	$int2=intval($bool);
	echo "<br>";
	var_dump($int1);
	echo "<br>";
	var_dump($int2);
	echo "<br>";
	$float1=(float)$bool;
	$float2=floatval($bool);
	var_dump($float1);
	var_dump($float2);
	echo "<hr>";
	$str1=(string)$bool;
	$str2=strval($bool);
	var_dump($str1);
	var_dump($str2);
	echo "<hr>";
	date_default_timezone_set("Etc/GMT-8");
	echo date("Y-m-d H:i:s,time() D");
	echo "<br><hr>";
	$hour=date("H");
	$week=date("D");
		switch ($week) {
			case 'Mon':
				echo "周一";			
				break;
			case 'Tue':
				echo "周二";
				break;
			case 'Wed':
				echo "周三";
				break;
			case 'Thu':
				echo "周四";
				break;
			case 'Fri':
				echo "周五";
				break;
			case 'Sat':
				echo "周六";
				break;
				
		default:
			echo "周天";
			break;
	}
	echo "<br><hr>";
	if($hour>=0&&$hour<5){
		echo "具体时间:".date("Y-m-d H:i:s")."<br>";
		echo "睡眠是给失眠者的救赎";
		
	}elseif ($hour>=5&&$hour<9) {
		echo "具体时间:".date("Y-m-d H:i:s")."<br>";
		echo "早晨是崭新的开端";
		
	}elseif ($hour>=9&&$hour<12) {
		echo "具体时间:".date("Y-m-d H:i:s")."<br>";
		echo "上午是专注的时间";
		
	}elseif ($hour>=12&&$hour<14) {
		echo "具体时间:".date("Y-m-d H:i:s")."<br>";
		echo "午休让下午精力充沛";
	}elseif ($hour>=14&&$hour<18) {
		echo "具体时间:".date("Y-m-d H:i:s")."<br>";
		echo "下午好";
	}elseif ($hour>=18&&$hour<0) {
		echo "具体时间:".date("Y-m-d H:i:s")."<br>";
		echo "夜晚让一些回归平静";
	}
	echo "<br><hr>";
//-----------------------------------------
	define(num, 20);
	$ji="奇数:";
	$ou="偶数:";
	for ($i=1; $i <=num; $i++){ 
		if($i%2==0){
			$ou.=$i.",";
		}else{
			$ji.=$i.",";
		}
	}
	$ji=substr($ji,0,strlen($ji)-1);
	$ou=substr($ou,0,strlen($ou)-1);
	echo "$ji<br>";
	echo "$ou<br>";
	echo "<hr>";
//-----------------------------------------
	for ($i=1; $i <10 ; $i++) { 
		for ($j=1; $j <=$i ; $j++) {
			echo "$j*$i=".$i*$j."&nbsp;&nbsp;&nbsp;&nbsp;";
		}
		echo "<br>";
	}
	echo "<hr><hr>";
//-----------------------------------------
for ($i=100;$i<1000;$i++) { 
	$g=$i%10;
	$s=$i/10%10;
	$b=$i/10/10%10;
	if(($g*$g*$g+$s*$s*$s+$b*$b*$b)==$i){
		echo $i."&nbsp;&nbsp;&nbsp;&nbsp;";
	}
}
echo "<hr>";
//----------------------------------------

for ($i=1; $i <1000 ; $i++) { 
	if (substr($i,0,1)==substr($i,strlen($i)-1,1)) {
		echo $i."&nbsp;&nbsp;&nbsp;";
	}
}
echo "<br><hr>";
//---------------------------------------
//数组遍历 foreach循环
$message=array(
		'name'=>'和学博',
		'sex'=>'男',
		'age'=>'21',
		'phone'=>'1786028',
		'address'=>'山东省聊城市',
	);

foreach ($message as  $value) {
	echo "$value","&nbsp;";
}
?>