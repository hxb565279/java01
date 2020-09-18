<?php
echo "<mete charset='UTF-8'>";
$conn = mysqli_connect('localhost', 'root', '123456', 'php')
or die("<script>alert('连接数据库失败') </script>");
if ($conn) {
    session_start();
    $username = $_POST['userName'];
    $password = $_POST['pwd'];
    $_SESSION['c_name']=$username;
    if ($username==null||$password==null){
        die("<script>alert('用户名或密码为空') ;window.location.href='login.html';</script>");
    }else{
   $result =  $conn->query( "select * from db_user where u_name='$username' and u_password='$password' ");
   $row = $result->fetch_row();
//        var_dump($row);
        if ($row){
            die("<script>alert('登录成功') ;window.location.href='index.php';</script>");
        }else{
            die("<script>alert('账户不存在或密码不对');window.location.href='login.html';</script>");
        }
    }

//      $select_sql = "select * from student";
//      $query = mysqli_query($conn,$select_sql);
//      while ($result=mysqli_fetch_array($query,MYSQLI_ASSOC)){
//          print_r($result);
//      }//
//  mysqli_set_charset($conn,'UTF8');
//  $insert_sql = "insert into classes values (default ,'php','王五')";
//   mysqli_query($conn,$insert_sql);
} else {
    die("<script>alert('登录失败,请重新登录');window.location.href='login.html';</script>");
}


//	if ($_POST["userName"]=="和学博"&&$_POST["pwd"]=="123") {
//		die("
//			<script>
//				alert('登录成功!');
//			</script>");
//	}else{
//		die("<script>
//				alert('登录失败！');
//
//			</script>");
//	}

?>