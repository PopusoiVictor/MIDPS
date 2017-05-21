<?php @session_start(); ?>
<?php if(@$_SESSION['username']) :?>
	  <div style="margin-top: 15px; ">
	   				<span class="login">Bine ai venit, </span>
	   				<span class="user"><?=@$_SESSION['username'];?></span>
			 </div>
<?php else: ?>
	<form class="form-horizontal" method="post" action="index.php">
					<div class="form-group">
					<div class="form">
						<label for="usr">
							<input type="text" name="username"  class="form-control" placeholder="username" style="margin-top: 10px;padding-left: 5px ">
						</label>
						<label for="usr">
							<input type="password" name="password" class="form-control" placeholder="password" style="margin-top: 10px;padding-left: 5px">
						</label>
						<button type="submit1" name="submit1" class="btn btn-success">ok</button>
					</div>
				</div>	
				</form>
			 <div class="clear"></div>
<?php endif; ?>	