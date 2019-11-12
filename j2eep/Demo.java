import java.sql.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class Demo1 extends JFrame implements ActionListener {
	JLabel l,lnm,lage;
	JTextField tnm,tage;
	JButton b1,b2,b3,b4,b5,b6,b7;
	Connection con;
	Statement st;
	ResultSet rs;
	Demo1(){
		Container c= getContentPane();		
		c.setLayout(new FlowLayout(FlowLayout.LEFT));
		
		lnm = new JLabel("Name ");
		lnm.setBounds(10,40,180,30);
		c.add(lnm);
		
		tnm = new JTextField(10);
		tnm.setBounds(90,40,180,30);
		c.add(tnm);
		
		lage = new JLabel("Age ");
		lage.setBounds(10,90,180,30);
		c.add(lage);
		
		tage = new JTextField(10);
		tage.setBounds(90,90,180,30);
		c.add(tage);
		
		b1 = new JButton("Add");
		b1.setBounds(200,140,70,30);
		c.add(b1);
		
		b2 = new JButton("Update");
		b2.setBounds(280,140,70,30);
		c.add(b2);
		
		b3 = new JButton("Delete");
		b3.setBounds(360,140,70,30);
		c.add(b3);
		
		l = new JLabel(" ");
		l.setBounds(640,140,70,30);
		c.add(l);
		
		b4 = new JButton("First");
		b4.setBounds(480,140,70,30);
		c.add(b4);
		
		b5 = new JButton("Next");
		b5.setBounds(520,140,70,30);
		c.add(b5);		
		
		b6 = new JButton("Previous");
		b6.setBounds(560,140,70,30);
		c.add(b6);
		
		b7 = new JButton("Last");
		b7.setBounds(600,140,70,30);
		c.add(b7);
		
		b1.addActionListener(this);
		b2.addActionListener(this);
		b3.addActionListener(this);
		b4.addActionListener(this);
		b5.addActionListener(this);
		b6.addActionListener(this);
		b7.addActionListener(this);
		
		try{
			Class.forName("com.mysql.jdbc.Driver");
			con = DriverManager.getConnection("jdbc:mysql://localhost:3306/keyur","root","");
			st = con.createStatement();
			st = con.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE,ResultSet.CONCUR_UPDATABLE);
			rs = st.executeQuery("select * from studd");
		}
		catch(ClassNotFoundException e){
			l.setText(e.getMessage());
		}
		catch(SQLException e){
			l.setText(e.getMessage());
		}
	}
	public void actionPerformed(ActionEvent ae){
		if(ae.getSource() == b1){
			try{
				String snm = tnm.getText().toString();
				String age = tage.getText().toString();
				String s = "insert into studd values('"+snm+"','"+age+"')";
				
				st.executeUpdate(s);
				//con.commit();
				l.setText("Record Added");
			}
			catch(SQLException e){
				l.setText(e.getMessage());
			}
			catch(Exception e){
				l.setText(e.getMessage());
			}
		}
		if(ae.getSource() == b2){
			try{
				String snm = tnm.getText().toString();
				String age = tage.getText().toString();
				String s = "update studd set age='"+age+"' where name='"+snm+"'";
				
				int i = st.executeUpdate(s);
			}
			catch(SQLException e){
				l.setText(e.getMessage());
			}
			catch(Exception e){
				l.setText(e.getMessage());
			}
		}
		if(ae.getSource() == b3){
			try{
				String snm = tnm.getText().toString();
				String s = "delete from studd where name='"+snm+"'";
				st.executeUpdate(s);
				//con.commit();
				l.setText("Record Deleted");
			}
			catch(SQLException e){
				l.setText(e.getMessage());
			}
			catch(Exception e){
				l.setText(e.getMessage());
			}
		}
		try{
			if(ae.getSource() == b4){
				String s1,s2;
				rs.first();
				s1 = rs.getString(1);
				s2 = rs.getString(2);
				tnm.setText(s1);
				tage.setText(s2);				
			}
			if(ae.getSource() == b5){
				String s1,s2;
				rs.next();
				s1 = rs.getString(1);
				s2 = rs.getString(2);
				tnm.setText(s1);
				tage.setText(s2);				
			}
			if(ae.getSource() == b6){
				String s1,s2;
				rs.previous();
				s1 = rs.getString(1);
				s2 = rs.getString(2);
				tnm.setText(s1);
				tage.setText(s2);				
			}
			if(ae.getSource() == b7){
				String s1,s2;
				rs.last();
				s1 = rs.getString(1);
				s2 = rs.getString(2);
				tnm.setText(s1);
				tage.setText(s2);				
			}
		}
		catch(Exception e){
			System.out.println(e.getMessage());
		}
	}
}
public class Demo{
	public static void main(String a[]){
		Demo1 c = new Demo1();
		c.setVisible(true);
		c.setSize(500,500);
	}
}