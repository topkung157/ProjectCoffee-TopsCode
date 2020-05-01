<!DOCTYPE html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Coffe TsC</title>
<style>
            body{
                background-attachment:fixed;
            }
            body{
                margin: 0;
                padding: 0;
                background-image:url(https://data.1freewallpapers.com/download/glorious-purple.jpg)
            }
            .nav ul{
                list-style: none;
                background-color: #444;
                text-align: center;
                padding: 0;
                margin: 0;
            }
            .nav li{
                font-size: 1.2em;
                line-height: 40px;
                text-align: left;
            }
            .nav a{
                text-decoration: none;
                color: #fff;
                display: block;
                padding-left: 15px;
                border-bottom: 1px solid #888;
                transition: .3s;
            }
            .nav a:hover{
                background-color: #005f5f;
            }
            .nav a.active{
                background-color: #aaa;
                color: #444;
                cursor: default;
            }
            .nav li li{
                font-size: .8em;
            }

            /* จอ windows*/
            @media screen and (min-width: 650px){
                .nav li {
                    width: 130px;
                    border-bottom: none;
                    height: 50px;
                    line-height: 50px;
                    font-size: 1.4em;
                    display: inline-block;
                    margin-right: -4px;
                }
                nav a{
                    border-bottom: none;
                }
                .nav > ul > li {
                    text-align: center;
                }
                .nav >ul >li > a {
                    padding-left: 0;
                }
                /*sub menu*/
                .nav li ul {
                    position: absolute;
                    display: none;
                    width: inherit;
                }
                .nav li:hover ul {
                    display: block;
                }
                .nav li ul li {
                    display: block;
                }
            }
            #กรอบ{
                border-radius: 25px;
                padding: 10px;
                width: 500px;
                height: 200px;
                background: white;
            }
            .right{
                position:absolute; 
                right:125px; 
                top:300px; 
                width:150px; 
                height:100px;
            }
            .font{
                font-family: 'Acme', sans-serif;
            }
        </style>
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
        <link rel="stylesheet" href="css/style.css">
</head>
 
<body>
<header>
            <div class="nav">
                <ul>
                    <li class="logo"><a href="#">Coffee</a></li>
                    <li class="item"><a href="http://localhost/coffee/Home.html">Home</a></li>
                    <li class="item"><a href="http://localhost/coffee/product.php">Order</a></li>
                    <li class="item"><a href="http://localhost/coffee/DataCoffee.html">DataCoffee</a></li>
                    <li class="item"><a href="#">ติดต่อ</a>
                        <ul>
                            <li><a href="https://www.facebook.com/TagTeamch-754360601280439/">เพจ</a></li>
                            <li><a href="เบอร์ติดต่อ.html">เบอร์ติดต่อ</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </header>
        <div class="right" style="text-align: right; width:195px; height:243px; float: inherit;">
            <script language="javascript">var cutekiWidget=1; var cutekiLeng="en"</script>
            <script type="text/javascript" language="javascript" src="http://www.cuteki.com/widgets/calendars/cuteki-calendar_v3.js"></script>
        </div>
        <iframe src="https://www.facebook.com/plugins/page.php?href=https%3A%2F%2Fwww.facebook.com%2FTagTeamch-754360601280439%2F&tabs=timeline&width=340&height=500&small_header=false&adapt_container_width=true&hide_cover=false&show_facepile=true&appId" 
        width="340" height="500" style="position: absolute; right:50px; top:560px; border:none;overflow:hidden" scrolling="no" 
        frameborder="0" allowTransparency="true" allow="encrypted-media"></iframe>
        <center><img src="img/logo.png"></center>
<table width="600" border="1" align="center" bordercolor="#666666">
  <tr>
    <td width="91" align="center" bgcolor="#CCCCCC"><strong>ภาพ</strong></td>
    <td width="200" align="center" bgcolor="#CCCCCC"><strong>กาแฟ</strong></td>
    <td width="44" align="center" bgcolor="#CCCCCC"><strong>ราคา</strong></td>
    <td width="100" align="center" bgcolor="#CCCCCC"><strong>รายละเอียดกาแฟ</strong></td>
  </tr><br>
  
  
  <?php
  include("connect.inc");
  $sql = "select * from product order by p_id";
  $result = mysqli_query($conn, $sql);
  while($row = mysqli_fetch_array($result))
  {
  	echo "<tr>";
	  echo "<td align='center'><img src='img/" . $row["p_pic"] ." ' width='100'></td>";
	  echo "<td align='left'>" . $row["p_name"] . "</td>";
    echo "<td align='center'>" .number_format($row["p_price"],2). "</td>";
    echo "<td align='center'><a href='product_detail.php?p_id=$row[p_id]'>คลิก</a></td>";
	echo "</tr>";
  }
  ?>
</table>