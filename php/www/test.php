<?php
	
	$name="和学博";
	$sex="男";
	$age=21;
	$family="山东省聊城市东昌府区";
	$address="潍坊学院";
	$dormitory="四号公寓4401";
	echo "我是$name,听名字就知道是个{$sex}孩，我来自$family,我现在就读于$address,我住在$dormitory";
	echo "<br>";
	echo "<hr>";
	
	$status1=0;
	$status2=false;
	$status3=null;
	if($status1==$status2&&$status1==$status3){
		echo '3者相等';
	}else{
		echo '3者不相等';
	}
	echo '<br>';
	echo '第一个变量类型是：'.gettype($status1);
	echo '<br>';
	echo '第二个变量类型是：'.gettype($status2);
	echo '<br>';
	echo '第三个变量类型是：'.gettype($status3);
	echo '<br>';
	if($status1===$status2&&$status1===$status3){
		echo '3者相等';
	}else{
		echo '3者不相等';
	}
	echo '<br>';
	echo (integer)false;
	echo (integer)true;
	echo "<br>";
	$x=4;
	$y=6;
	$z=x+y;
	define(SCHOOL, "潍坊学院");
	echo "常量用define定义，输出常量值不加引号，输出常量名加引号,例如：";
	echo "<br>";
	echo "不加引号，输出值：".SCHOOL;
	echo "<br>";
	echo "加引号，输出名：SCHOOL";
	echo "<br>";
	function test1(){
		$a=$GLOBALS['x']*$GLOBALS['y'];
		echo "<br>";
		echo "输出全局变量x：{$GLOBALS['x']}";
		echo "<br>";
		echo "输出局部变量a：$a";
		echo "<br>";
	}
	test1();
	echo "<br>";
	$bool=false;
	$string="tom";
	$int=1;
	$float=1.00;

	var_dump($bool);
	var_dump($string);
	var_dump($int);
	var_dump($float);

	$sum=$bool+$string+$int+$float;
	var_dump($sum);
	echo "<br>";
	$boolean=false;
	$int1=(int)$boolean;
	$int2=intval($boolean);
	echo "<br>";
	var_dump($int1);
	echo "<br>";
	var_dump($int2);
	unset($boolean);
	echo "<br>";
	var_dump(empty($boolean));
	echo "<br>";
	var_dump(isset($boolean));
	echo "<hr>";
	$color=array('red','blue','green');
	print_r($color);
	echo "<br><hr>";
	$color2[0]='锄禾日当午';
	$color2[1]='汗滴禾下土';
	$color2[2]='谁知盘中餐';
	$color2[3]='粒粒皆辛苦';
	echo "<br><hr>";
	for($i=0;$i<count($color2);$i++){
		echo $color2[$i];
		echo "<br><hr>";
	}
	echo "<pre>";
	$message=array(
		array('name'=>'张三',
		'age'=>'21',
		'sex'=>'男',
		'major'=>'计算机科学与技术（软件外包）',
		'class'=>'二',
		'height'=>'175',
		'weight'=>'60kg',
		'phone'=>'17860285878',
		),
	array(
		'name'=>'噶硕',
		'age'=>'20',
		'sex'=>'男',
		'major'=>'计算机科学与技术（软件外包）',
		'class'=>'二',
		'height'=>'188',
		'weight'=>'100kg！！！！！=二百斤',
		'phone'=>'17860285800',
		'JJ_height'=>'20ηm'
		),
	array('name'=>'小博博',
		'age'=>'21',
		'sex'=>'男',
		'major'=>'计算机科学与技术（软件外包）',
		'class'=>'一',
		'height'=>'178',
		'weight'=>'80kg',
		'phone'=>'17860282228',
		)

	);
	for ($i=0; $i <count($message ); $i++) { 
		foreach ($message[$i] as $value) {
		echo "$value"." ";
		}	
	echo "<br>";
	}
	
	/*echo count($message);
	print_r($message);
	echo "<br><hr>";
	echo count($message);
	echo "<br>";
	for ($i=0; $i < count($message); $i++) { 
		echo $message[$i]['name'];
		echo "<br>";
	}	*/


	//$str = "A 'quote' is <b>bold</b>";
	//echo $str;
?>