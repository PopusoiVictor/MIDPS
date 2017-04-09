<?php @session_start(); ?>
<?php if(@$_SESSION['username']) :?>
<div class="col span_1_of_3">
					<div class="contact_info">
			    	 	<h3>Harta</h3>
			    	 		<div class="map">
					   			<iframe width="100%" height="175" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.co.in/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=Studentilor+St,+Chisinau,+Moldova&amp;aq=4&amp;oq=light&amp;sll=47.0595369,28.8682683,&amp;sspn=0.04941,0.104628&amp;ie=UTF8&amp;hq=&amp;hnear=Studentilor+St,+Chisinau,+Moldova&amp;t=m&amp;z=14&amp;ll=47.0595369,28.8682683&amp;output=embed">	
					   			</iframe><br><small><a href="https://maps.google.co.in/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=Studentilor+St,+Chisinau,+Moldova&amp;aq=4&amp;oq=light&amp;sll=47.0595369,28.8682683,&amp;sspn=0.04941,0.104628&amp;ie=UTF8&amp;hq=&amp;hnear=Studentilor+St,+Chisinau,+Moldova&amp;t=m&amp;z=14&amp;ll=47.0595369,28.8682683" style="color: #5A5A5A;text-align:left;font-size:12px">Mareste harta</a></small>
					   		</div>
      				</div>
      			<div class="company_address">
				     	<h3>Informatii</h3>
						<p>str. Studentilor 7/1,</p>
						<p>sect. Riscani, mun. Chisinau,</p>
						<p>Republica Moldova</p>
				   		<p>Phone: +(373) 22 161989</p>
				   		<p>Fax: +(373) 22 246 0472</p>
				 	 	<p>Email: <span>smotramd@gmail.com</span></p>
				   </div>
				</div>	
	   <div class="col span_2_of_3">
				  <div class="contact-form">
				  	<h3>Expediaza un mesaj!</h3>
					      <form method="post" action="contacte.php">
					    	<div>
						    	<span><label>Nume</label></span>
						    	<span><input name="userName" type="text" class="textbox"></span>
						    </div>
						    <div>
						    	<span><label>E-mail</label></span>
						    	<span><input name="userEmail" type="text" class="textbox"></span>
						    </div>
						    <div>
						     	<span><label>Telefon</label></span>
						    	<span><input name="userPhone" type="text" class="textbox"></span>
						    </div>
						    <div>
						    	<span><label>Subiect</label></span>
						    	<span><textarea name="userMsg"> </textarea></span>
						    </div>
						   <div>
						   		<span><input type="submit" name="submit" value="Trimite"></span>
						  </div>
					    </form>
				    </div>
  				</div>		
  			<div class="clear"></div>	
		 </div>
<?php else: ?>
	   <div class="col span_1_of_3">
					<div class="contact_info">
			    	 	<h3>Harta</h3>
			    	 		<div class="map">
					   			<iframe width="100%" height="175" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.co.in/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=Studentilor+St,+Chisinau,+Moldova&amp;aq=4&amp;oq=light&amp;sll=47.0595369,28.8682683,&amp;sspn=0.04941,0.104628&amp;ie=UTF8&amp;hq=&amp;hnear=Studentilor+St,+Chisinau,+Moldova&amp;t=m&amp;z=14&amp;ll=47.0595369,28.8682683&amp;output=embed">	
					   			</iframe><br><small><a href="https://maps.google.co.in/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=Studentilor+St,+Chisinau,+Moldova&amp;aq=4&amp;oq=light&amp;sll=47.0595369,28.8682683,&amp;sspn=0.04941,0.104628&amp;ie=UTF8&amp;hq=&amp;hnear=Studentilor+St,+Chisinau,+Moldova&amp;t=m&amp;z=14&amp;ll=47.0595369,28.8682683" style="color: #5A5A5A;text-align:left;font-size:12px">Mareste harta</a></small>
					   		</div>
      				</div>
      			<div class="company_address">
				     	<h3>Informatii</h3>
						<p>str. Studentilor 7/1,</p>
						<p>sect. Riscani, mun. Chisinau,</p>
						<p>Republica Moldova</p>
				   		<p>Phone: +(373) 22 161989</p>
				   		<p>Fax: +(373) 22 246 0472</p>
				 	 	<p>Email: <span>smotramd@gmail.com</span></p>
				   </div>
				</div>	
				 <div class="col span_2_of_3">
				  <div class="contact-form">
				  	<a href="#"><img src="images/smotra.png" alt=" " /></a>
				    </div>
  				</div>			
			 <div class="clear"></div>
		 </div>
<?php endif; ?>	