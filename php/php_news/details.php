<?php
session_start();
?>
<html>
<head>
    <meta http-equiv=Content-Type content="text/html; charset=utf-8">
    <title>新闻网站</title>
    <link href="./main.css" rel="stylesheet" type="text/css"/>
    <script src="./jquery.js" type="text/javascript"></script>
    <script type="text/javascript">
        function publish() {
            var n_id = document.getElementById("n_id").value;
            var co_message = document.getElementById("co_message").value;
            $.ajax({
                url: 'comment.php',
                data: {
                    'n_id': n_id,
                    'co_message': co_message
                },
                type: 'post',
                cache: false,
                dataType: 'json',
                success: function (data) {
                    alert("发布成功");
                    location.reload();
                },
                error: function () {
                    alert("发布失败");
                }
            });
        }
    </script>
</head>
<body>
<div class="contain">
    <!-- header开始 -->
    <div class="logo"><a href="index.php"></a></div>
    <div class="menu">
        <ul>
            <?php
            @$connect = mysqli_connect('localhost', 'root', '123456', 'php');
            mysqli_set_charset($connect, 'utf8');
            if (!$connect) {
                die('数据库连接失败！ ' . mysqli_error($connect));
            }
            $result = $connect->query("SELECT * from db_type WHERE t_status='1' ");
               while($menu=mysqli_fetch_array($result,MYSQLI_ASSOC)){
                  echo "<li><span>|&nbsp;&nbsp;<span>
                        <a href=list.php?id=".$menu['t_id'].">"
                        .$menu['t_name']."</a></li>";
//                  var_dump($menu);
               }

            ?>
        </ul>
        <?php
        if (!isset($_SESSION['c_name'])) {
            ?>
            <ul id="login">
                <li><a href="register.html" target="_self">注册</a></li>
                <li><a href="login.html" target="_self">登录</a></li>
            </ul>
        <?php } else {
            ?>
            <ul id="loged">
                <li><a href="login.php?flag=logout" target="_self">退出登录</a></li>
                <li><a>欢迎您,<?php echo $_SESSION['c_name']; ?></a></li>
            </ul>
        <?php } ?>
    </div>
    <div class="line1"></div>
    <div class="main">
        <div class="select">
            <form action="#" method="post">
                <div class="select_left">
                    <strong>搜索:</strong>
                    <input name="keyword" placeholder="请输入关键字"/>
                </div>
                <div class="select_right">
                    <input name="Submit" type="Submit" value="立即搜索"/>
                </div>
            </form>
        </div>
        <div class="currect_position">
            当前位置：<a href="index.php">新闻网站</a>&nbsp;>&nbsp;
            <?php
            $id = $_GET['id'];
            $sql = "SELECT N.*,T.t_name from db_news as N LEFT JOIN db_type AS T ON (N.n_type=T.t_id)  WHERE N.n_id=$id";
            $result = $connect->query($sql);
            $news=mysqli_fetch_array($result,MYSQLI_ASSOC);
//            $news = $result->fetch_row();
            if (!$news) {
                printf("Error: %s\n", mysqli_error($connect));
            }

            echo $news['t_name'] . '&nbsp;>&nbsp;' . $news['n_title'];
            ?>
        </div>
        <div style="clear: both;"></div>
        <!-- header结束 -->
        <!-- 页面主要内容开始 -->
        <div class="details">
            <div class="details_news_title">
                <?php echo $news['n_title']; ?>
            </div>
            <div class="details_news_author">
                <span>作者：<?php echo $news['n_author']; ?> </span>
                <span>点击数：<strong><?php echo $news['n_nums']; ?></strong></span>
                <span>发布时间：<?php echo $news['n_addtime']; ?></span>
            </div>
            <div class="details_news_message">
                <?php echo $news['n_message']; ?>
            </div>
        </div>
        <div class="answer">
            <div class="details_news_title">评论</div>
            <div class="answer_cont">
                <?php
                $pagesize = 6;
                $sql = "select count(*) from db_comment where co_news_id=$id";
                $count = $connect->query( $sql);
                $totals = mysqli_fetch_array($count);
                if (!$totals) {
                    printf("Error: %s\n", mysqli_error($connect));
                }
                $numrows = $totals[0];

                if ($numrows % $pagesize) {
                    $pages = intval($numrows / $pagesize) + 1;
                } else {
                    $pages = intval($numrows / $pagesize);
                }

                if (!isset($_GET['page']) || $_GET['page'] > $pages) {
                    $page = 1;
                } else {
                    $page = intval($_GET['page']);
                }
                $start = ($page - 1) * $pagesize;
                $sql = "SELECT c.*,a.c_name FROM db_comment c LEFT JOIN db_customer a ON c.co_customer_id=a.c_id WHERE c.co_news_id=$id ORDER BY c.co_addtime DESC LIMIT $start,$pagesize";

                $result = mysqli_query($connect, $sql);
                while ($comments = mysqli_fetch_array($result, MYSQLI_ASSOC)) {
                    ?>
                    <div class="answer_list">
                        <span><?php echo $comments['c_name']; ?>:</span><?php echo $comments['co_message']; ?>
                        <p><?php echo date("Y-m-d", $comments['co_addtime']); ?></p>
                    </div>
                <?php } ?>
            </div>
            <div class="details_news_bottom">
                <?php
                /*分页部分页面展示 开始*/
                //当前页是最后两页
                if ($page != 1) {
                    echo "<a href='list.php?id=$id&page=1'>";
                    echo "首页";
                    echo "</a> &nbsp";
                }
                if ($pages - $page < 2) {
                    //总页数不大于三页
                    if ($pages <= 3) {
                        for ($i = 1; $i <= $pages; $i++) {
                            if ($page != $i) {
                                echo "<a href='details?id=$id&page=$i'>";
                                echo $i;
                                echo "</a> &nbsp";
                            } else {
                                echo $i . " &nbsp";
                            }
                        }
                    } //总页数大于三页
                    else {
                        for ($i = $page - 2; $i <= $pages; $i++) {
                            if ($page != $i) {
                                echo "<a href='details?id=$id&page=$i'>";
                                echo $i;
                                echo "</a> &nbsp";
                            } else {
                                echo $i . " &nbsp";
                            }
                        }
                    }
                } //当前页不是最后两页
                else {
                    //当前页不是最前两页
                    if ($page > 2) {
                        for ($i = $page - 2; $i <= $page + 2; $i++) {
                            if ($page != $i) {
                                echo "<a href='details?id=$id&page=$i'>";
                                echo $i;
                                echo "</a> &nbsp";
                            } else {
                                echo $i . " &nbsp";
                            }
                        }
                    } //当前页是最前两页
                    else {
                        for ($i = 1; $i <= $page + 2; $i++) {
                            if ($page != $i) {
                                echo "<a href='details?id=$id&page=$i'>";
                                echo $i;
                                echo "</a> &nbsp";
                            } else {
                                echo $i . " &nbsp";
                            }
                        }
                    }
                }
                if ($page != $pages && $pages != 0) {
                    echo "<a href='list.php?id=$id&page=$pages'>";
                    echo "尾页";
                    echo "</a> ";
                }
                if ($pages != 0) {
                    echo "&nbsp&nbsp&nbsp$page/$pages 页   &nbsp&nbsp 共 $numrows 条评论";
                } else {
                    echo "暂无相关信息";
                }
                /*分页部分页面展示 结束*/
                ?>
            </div>
            <div class="answer_cont_bottom">
                <?php if (!isset($_SESSION['c_name'])) { ?>
                    你尚未登录，请登录后再进行评论。
                    <p>
                        <a href="register.html" target="_self">注册</a>
                        <a href="login.html" target="_self">登录</a>
                    </p>
                <?php } else { ?>
                    <table>
                        <input type="hidden" name="n_id" id="n_id" value="<?php echo $news['n_id'] ?>">
                        <tr>
                            <td> 我的评论：</td>
                            <td>
                                <textarea name="co_message" id="co_message" rows="2" cols="90"></textarea>
                            </td>
                        </tr>
                        <tr>
                            <td colspan=2 align=center>
                                <input type="button" onclick="publish()" value="发布">
                            </td>
                        </tr>
                    </table>
                <?php } ?>
            </div>

        </div>

    </div>

    <div class="footer">
        <a href="http://www.121ugrow.com/" target="_blank">英谷教育</a>|
        <a href="http://www.baidu.com/" target="_blank">百度</a>|
        <a href="http://www.taobao.com/" target="_blank">淘宝</a>|
        <a href="http://www.sina.com/" target="_blank">新浪</a>
    </div>
</div>
<div style="display:none;"></div>
</body>
</html>