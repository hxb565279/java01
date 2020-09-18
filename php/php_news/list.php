<html>
<head>
	<meta http-equiv=Content-Type content="text/html; charset=utf-8" >
	<title>新闻网站</title>
	<link href="./main.css" rel="stylesheet" type="text/css" />
</head>
<body>
<ul>

</ul>
<div class="contain">
<!-- header开始 -->
  <div class="logo"><a href="index.php"></a></div>
  <div class="menu">
    <ul>

        <li><span>|&nbsp;&nbsp;<span><a href="list.php?id=12">体育新闻</a></li>
        <li><span>|&nbsp;&nbsp;<span><a href="list.php?id=13">时政新闻</a></li>
        <li><span>|&nbsp;&nbsp;<span><a href="list.php?id=14">国际新闻</a></li>
        <li><span>|&nbsp;&nbsp;<span><a href="list.php?id=15">娱乐新闻</a></li>
	</ul>

      <?php
      session_start();
      $username = $_SESSION['c_name'];
      if ($username !=null){
          echo " &nbsp;&nbsp;&nbsp; 你好,欢迎",  $username; ?>
          <li><a href="logout.php" target="_self">注销</a></li>
          <?php
      }
      else{
          ?>
          <br>
          <li><a href="register.html" target="_self">注册</a></li>
          <li><a href="login.html" target="_self">登录</a></li>
          </ul>
      <?php   }?>


  </div>
   <div class="line1" ></div>
   <div class="main">
	 <div class="select">
	    <form action="search.php" method="post" >
		   <div class="select_left">
			   <strong>搜索:</strong>
			   <input name="keyword"  placeholder="请输入关键字"/>
		   </div>
		   <div class="select_right">
			   <input name="Submit" type="Submit"  value="立即搜索"  />
		   </div>
		</form>		
	 </div>
	 <div class="currect_position">
		 当前位置：<a href="index.php">新闻网站</a>&nbsp;>&nbsp新闻分类
	 </div>
	 <div style="clear: both;"></div>
<!-- header结束 -->
<!-- 页面主要内容开始 -->	
	 <div class="details" >

	   <table>
<?php
$id = $_GET['id'];
           $conn = mysqli_connect('localhost','root','123456','php');
           if (!$conn){
           echo "连接失败";
           }
           mysqli_set_charset($conn,'utf8');
           $result=  $conn->query("select * from db_news where n_type = '$id' ");
           while ( $news=mysqli_fetch_array($result,MYSQLI_ASSOC)){?>
		 <tr>
		   <td>
			 <a href='details.php?id=12'>
                 <?php
             echo  "新闻标题: ",  $news['n_title'];
                 ?>
			 </a>
		   </td>
		 </tr>
	     <tr>
		   <td>
			 <font color='#8F8C89'>
			         日期：2020-09-05
			         点击：<?php echo $news['n_nums'] ?>
			 </font>
		   </td>
		 </tr>
		 <tr>
		   <td>
		    <?php  echo $news['n_message']?>
		   </td>
		 </tr>
           <?php
           }?>


	   </table>
         <table>
<!--     <tr>-->
<!--       <td>-->
<!--       <a href='details.php?id=12'>-->
<!--            新闻标题-->
<!--       </a>-->
<!--       </td>-->
<!--     </tr>-->
<!--       <tr>-->
<!--       <td>-->
<!--       <font color='#8F8C89'>-->
<!--               日期：2020-09-05-->
<!--               点击：23-->
<!--       </font>-->
<!--       </td>-->
<!--     </tr>-->
<!--     <tr>-->
<!--       <td>-->
<!--          这是新闻的内容...-->
<!--       </td>-->
<!--     </tr>-->
<!--     </table>-->
<!--         <table>-->
<!--     <tr>-->
<!--       <td>-->
<!--       <a href='details.php?id=12'>-->
<!--            新闻标题-->
<!--       </a>-->
<!--       </td>-->
<!--     </tr>-->
<!--       <tr>-->
<!--       <td>-->
<!--       <font color='#8F8C89'>-->
<!--               日期：2020-09-05-->
<!--               点击：23-->
<!--       </font>-->
<!--       </td>-->
<!--     </tr>-->
<!--     <tr>-->
<!--       <td>-->
<!--          这是新闻的内容...-->
<!--       </td>-->
<!--     </tr>-->
<!--     </table>-->
<!--         <table>-->
<!--     <tr>-->
<!--       <td>-->
<!--       <a href='details.php?id=#'>-->
<!--            新闻标题-->
<!--       </a>-->
<!--       </td>-->
<!--     </tr>-->
<!--       <tr>-->
<!--       <td>-->
<!--       <font color='#8F8C89'>-->
<!--               日期：2020-09-05-->
<!--               点击：23-->
<!--       </font>-->
<!--       </td>-->
<!--     </tr>-->
<!--     <tr>-->
<!--       <td>-->
<!--          这是新闻的内容...-->
<!--       </td>-->
<!--     </tr>-->
<!--     </table>-->
<!--         <table>-->
<!--     <tr>-->
<!--       <td>-->
<!--       <a href='details.php?id=#'>-->
<!--            新闻标题-->
<!--       </a>-->
<!--       </td>-->
<!--     </tr>-->
<!--       <tr>-->
<!--       <td>-->
<!--       <font color='#8F8C89'>-->
<!--               日期：2020-09-05-->
<!--               点击：23-->
<!--       </font>-->
<!--       </td>-->
<!--     </tr>-->
<!--     <tr>-->
<!--       <td>-->
<!--          这是新闻的内容...-->
<!--       </td>-->
<!--     </tr>-->
<!--     </table>-->
<!--         <table>-->
<!--     <tr>-->
<!--       <td>-->
<!--       <a href='details.php?id=#'>-->
<!--            新闻标题-->
<!--       </a>-->
<!--       </td>-->
<!--     </tr>-->
<!--       <tr>-->
<!--       <td>-->
<!--       <font color='#8F8C89'>-->
<!--               日期：2020-09-05-->
<!--               点击：23-->
<!--       </font>-->
<!--       </td>-->
<!--     </tr>-->
<!--     <tr>-->
<!--       <td>-->
<!--          这是新闻的内容...-->
<!--       </td>-->
<!--     </tr>-->
     </table>
	   <div class='line2' ></div>

       <div class="page">
      
        </div>
	</div>
  </div>
<!-- 页面主要内容结束 -->
<!-- footer开始 -->
  <div class="footer">
		<?php 
		  $link=array(
		      array('link'=>'http://www.121ugrow.com/','name'=>'英谷教育'),
		      array('link'=>'http://www.baidu.com/','name'=>'百度'),
		      array('link'=>'http://www.taobao.com/','name'=>'淘宝'),
		      array('link'=>'http://www.sina.com/','name'=>'新浪')
		  );
		  $num=count($link);
          for($i=0;$i<=$num-1;$i++){
              if($i<$num-1){
                  echo "<a href='". $link[$i]['link'] ."'>";
                  echo $link[$i]['name']."</a>";
                  echo '|';
              }else{
                  echo "<a href='". $link[$i]['link'] ."'>";
                  echo $link[$i]['name']."</a>";
              }    
          }		 
		?>
	</div>
<!-- footer结束 -->	
</div>
</body>
</html>