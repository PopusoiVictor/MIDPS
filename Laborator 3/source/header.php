<?php @session_start(); ?>
<?php if(@$_SESSION['username']) :?>
	   <div class="user_name">
	   				<span style="color:#ffffff">Salut, </span>
	   				<span style="color:#ff0000"><?=@$_SESSION['username'];?></span>
			   </div>
		<div class="log_out">
			   <a href="logout.php"><img src="images/iesire.png" alt="" title="Iesire"></a>
			   </div>
			 <div class="clear"></div>
<?php else: ?>
	   <div class="login">
			   	   <span><a href="login.php"><img src="images/autentificare.png" alt="" title="Autentificare"></a></span>
			   </div>
			    <div class="register">
			   	   <span><a href="register.php"><img src="images/inregistrare.png" alt="" title="Inregistrare"></a></span>
			   </div>
			 <div class="clear"></div>
<?php endif; ?>	