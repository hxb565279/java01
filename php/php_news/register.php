<?php
$conn = mysqli_connect("localhost", "root", "123456", "php")
or die("<script>alert('连接数据库失败')</script>");
$name = $_POST['c_name'];
$password = $_POST['c_password'];
date_default_timezone_set("Etc/GMT-8");
$date = date('y-m-d,h-m-s');
$select_sql = "select * from db_user where u_name = '$name'";
echo "11";
$insert_sql = "insert into db_user   values (default ,'$name','$password','$date')";
 $result =   mysqli_query($conn,$select_sql);
if (!$result) {
    printf("Error: %s\n", mysqli_error($conn));
    exit();
}else{
    if (mysqli_num_rows($result)>0){
        echo "<script>alert('用户名已经存在！');window.location.href='register.html';</script>";
    }else{
         $query =  mysqli_query($conn,$insert_sql);
if ($query){
     die ("<script>alert('注册成功');
window.location.href='login.html';</script>");
}
else{
    die("<script>alert('失败')</script>");
}
    }
}

// while ($row>0){
//     die("<script>alert('用户名已经存在') ;window.location.href='register.html'</script>");
// }
// $query =  mysqli_query($conn,$insert_sql);
//if ($query){
//     die ("<script>alert('注册成功');
//window.location.href='login.html';</script>");
//}
//else{
//    die("<script>alert('失败')</script>");
//}


