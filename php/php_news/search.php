<html>
<head>
	<meta http-equiv=Content-Type content="text/html; charset=utf-8" >
	<title>新闻网站</title>
	<link href="./main.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div class="contain">
<!-- header开始 -->
  <div class="logo"><a href="index.php"></a></div>
  <div class="menu">
    <ul>
<?php 		 
   @$connect = mysqli_connect('localhost', 'root', '123456','php');
   mysqli_set_charset($connect,'utf8');
   if (!$connect) {
       die('数据库连接失败！ ' . mysql_error());
   }
   $result=mysqli_query($connect,"SELECT * from db_type WHERE t_status='1' ");
   while($menu=mysqli_fetch_array($result,MYSQLI_ASSOC)){
      echo "<li><span>|&nbsp;&nbsp;<span>
            <a href=list.php?id=".$menu['t_id'].">"
            .$menu['t_name']."</a></li>";
   }
?>			
	</ul>		

<?php 
	@session_start();
	if(!isset($_SESSION['c_name'])){ 
?>
    <ul id="login">	
	  <li><a href="register.html" target="_self">注册</a></li>
	  <li><a href="login.html" target="_self">登录</a></li>
	</ul>
<?php }else{?>
    <ul id="loged">
	  <li><a href="login.php?flag=logout" target="_self">退出登录</a></li>
	  <li><a>欢迎您,<?php echo $_SESSION['c_name']; ?></a></li>
	</ul>
<?php }?>			
	
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
<?php

    $key=(isset($_POST['keyword']))?$_POST['keyword']:$_GET['key'];
    $sql="select count(*) from db_news where n_title like  '%$key%' or n_message like '%$key%' or n_author like  '%$key%'";
    $count=mysqli_query($connect,$sql);
    $totals = mysqli_fetch_array($count);
    $numrows=$totals[0];  
    if(empty($key)){
        echo "搜索到所有新闻共<font color='red'>$numrows</font>篇>";
    }
    else{
        echo "搜索到与<font color='red'>$key</font>有关的新闻共<font color='red'>$numrows</font>篇>";
    }
   
?>:
	 </div>
	 <div style="clear: both;"></div>
<!-- header结束 -->
<!-- 页面主要内容开始 -->	
	 <div class="details" >
<?php
/*分页部分php程序 开始*/
    $pagesize=6;
    if ($numrows%$pagesize){
        $pages=intval($numrows/$pagesize)+1;
    }else{
        $pages=intval($numrows/$pagesize);
    }

    if(!isset($_GET['page'])||$_GET['page']>$pages){
        $page=1;
    }else{
        $page=intval($_GET['page']);
    }
    $start=($page-1)*$pagesize;
    $sql="select * from db_news where n_title like  '%$key%' or n_message like '%$key%' or n_author like  '%$key%' order by n_addtime desc limit $start,$pagesize";
    $result=mysqlI_query($connect,$sql);
    while($news=mysqli_fetch_array($result,MYSQLI_ASSOC)){
    /*分页部分php程序 结束*/
?>
	   <table>
		 <tr>
		   <td>
			 <a href='details.php?id=<?php echo $news['n_id']; ?>'>
			      <?php echo $news['n_title']; ?>
			 </a>
		   </td>
		 </tr>
	     <tr>
		   <td>
			 <font color='#8F8C89'>
			         日期：<?php echo $news['n_addtime']; ?>
			         点击：<?php echo $news['n_nums']; ?>
			 </font>
		   </td>
		 </tr>
		 <tr>
		   <td>
		      <?php echo  mb_substr($news['n_message'], 0, 80, 'utf-8'); ?>...
		   </td>
		 </tr>
	   </table>
	   <div class='line2' ></div>
<?php } ?>
       <div class="page">
<?php   
/*分页部分页面展示 开始*/
//当前页是最后两页
if($page!=1){
    echo "<a href='search.php?key=$key&page=1'>";
    echo "首页";
    echo "</a> &nbsp";
}
if($pages-$page<2){
    //总页数不大于三页
    if($pages<=3){     
        for($i=1;$i<=$pages;$i++){          
            if($page!=$i){
                echo "<a href='search.php?key=$key&page=$i'>";
                echo $i;
                echo "</a> &nbsp";
            }else{
                echo $i." &nbsp";
            }
        }       
    }
    //总页数大于三页
    else{
        for($i=$page-2;$i<=$pages;$i++){
            if($page!=$i){
                echo "<a href='search.php?key=$key&page=$i'>";
                echo $i;
                echo "</a> &nbsp";
            }else{
                echo $i." &nbsp";
            }
        }
    }
}
//当前页不是最后两页
else{
    //当前页不是最前两页
    if($page>2){
        for($i=$page-2;$i<=$page+2;$i++){
            if($page!=$i){
                echo "<a href='search.php?key=$key&page=$i'>";
                echo $i;
                echo "</a> &nbsp";
            }else{
                echo $i." &nbsp";
            }
        }
    }
    //当前页是最前两页
    else{
        for($i=1;$i<=$page+2;$i++){
            if($page!=$i){
                echo "<a href='search.php?key=$key&page=$i'>";
                echo $i;
                echo "</a> &nbsp";
            }else{
                echo $i." &nbsp";
            }
        }
    }
}
if($page!=$pages&&$pages!=0){
    echo "<a href='search.php?key=$key&page=$pages'>";
    echo "尾页";
    echo "</a> ";
}
if($pages!=0){
    echo "&nbsp&nbsp&nbsp$page/$pages 页   &nbsp&nbsp 共 $numrows 条新闻";
}
else{
    echo "暂无相关信息";
}
    /*分页部分页面展示 结束*/
?>           
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