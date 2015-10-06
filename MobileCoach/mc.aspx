<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mc.aspx.cs" Inherits="VzSoftphone.mc" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>Section scroller one-page template</title>
    <meta name="description" content="Mobile Coach." />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="generator" content="Codeply">

   <%-- <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css" />--%>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href="//cdnjs.cloudflare.com/ajax/libs/animate.css/3.1.1/animate.min.css" rel="stylesheet" />

    <link rel="stylesheet" href="css/styles.css" />

    <!-- <link rel="stylesheet" href="css/normalize.css" /> -->
    <script src="js/prefixfree.min.js"></script>
    <link href='http://fonts.googleapis.com/css?family=Vollkorn:400,700' rel='stylesheet' type='text/css'>
</head>
<body>
    <nav class="navbar navbar-trans navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar-collapsible">
                    <span class="sr-only">VZ SoftPhone</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand text-danger" href="#">VZ SoftPhone</a>
            </div>
            <div class="navbar-collapse collapse" id="navbar-collapsible">
                <ul class="nav navbar-nav navbar-left">
                    <li><a href="#section1">Home</a></li>
                    <li><a href="#section2">Live</a></li>
                    <li><a href="#section3">Report</a></li>

                    <li>&nbsp;</li>
                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="#" data-toggle="modal" data-target="#myModal"><i class="fa fa-heart-o fa-lg"></i></a></li>
                </ul>
            </div>
        </div>
    </nav>

    <section class="container-fluid" id="section1">
        <div class="v-center">
            <h1 class="text-center">VZ SoftPhone</h1>
            <h2 class="text-center lato animate slideInDown">Welcome <b>Mr Supervisor</b> </h2>
            <p class="text-center">
                <br>
                <a href="#" class="btn btn-danger btn-lg btn-huge lato" data-toggle="modal" data-target="#myModal">Agent Status/Reports</a>
            </p>
        </div>
        <a href="#section2">
            <div class="scroll-down bounceInDown animated">
                <span>
                    <i class="fa fa-angle-down fa-2x"></i>
                </span>
            </div>
        </a>
    </section>
    
    <section class="container-fluid" id="section2">
        <div class="container v-center">
            <div class="row">
                <div class="col">
                    <div class="row">
                        <div class="col-sm-12 text-center">
                            <div class="panel panel-default slideInLeft animate">
                                <div class="panel-heading">
                                    <h3>Live Update</h3>
                                </div>
                                <div class="panel-body">

                                    <!-- Table demo -->
                                    <div class="box-table">
                                        <table data-fn="contacts" data-url="http://localhost:51052/api/live"></table>
                                    </div>
                                    <hr>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                
                
            </div>
            <!--/row-->
            <div class="row">
                <br>
            </div>
        </div>
        <!--/container-->
    </section>
       
    <section class="container-fluid" id="section3">
        <h1 class="text-center">Report</h1>
        <div class="row">
            <div class="col-sm-6 col-sm-offset-3">
               <%-- <h3 class="text-center lato slideInUp animate">That <strong>Doesn't</strong> Have to Look Like Bootstrap.</h3>
                <br>--%>
                
                <br>
                <div class="text-center img-responsive thumbnail center-block " style="border: 10px solid #ddd;">
                  
                        <div class="" style="color:black;">
                             <table data-fn="report" style="width:100%" data-url="c2.json"></table>
                        </div>
                        
                   
                   
                </div>
            </div>
        </div>
    </section>

    
    <div class="scroll-up">
        <a href="#"><i class="fa fa-angle-up"></i></a>
    </div>

    <div id="myModal" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                    <h2 class="text-center">
                        <img src="//placehold.it/110" class="img-circle"><br>
                        Login</h2>
                </div>
                <div class="modal-body row">
                    <h6 class="text-center">COMPLETE THESE FIELDS TO SIGN UP</h6>
                    <form class="col-md-10 col-md-offset-1 col-xs-12 col-xs-offset-0">
                        <div class="form-group">
                            <input type="text" class="form-control input-lg" placeholder="Email">
                        </div>
                        <div class="form-group">
                            <input type="password" class="form-control input-lg" placeholder="Password">
                        </div>
                        <div class="form-group">
                            <button class="btn btn-danger btn-lg btn-block">Sign In</button>
                            <span class="pull-right"><a href="#">Register</a></span><span><a href="#">Need help?</a></span>
                        </div>
                    </form>
                </div>
                <div class="modal-footer">
                    <h6 class="text-center"><a href="">Privacy is important to us. Click here to read why.</a></h6>
                </div>
            </div>
        </div>
    </div>
    <!--scripts loaded here-->

    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>

    <script src="js/scripts.js"></script>
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script src="js/index.js"></script>
</body>
</html>
