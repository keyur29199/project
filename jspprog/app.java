import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import java.swing.*;
public class app extends JApplet
{
	public void paint(Graphics g)
	{
		Font f=new Font("Verdana",Font.Bold,32);
		g.setFont(f);
		g.drawString("plugin Demo",14,20);
		Color c=new Color(25,25,220);
		g.setColor(c);
		g.fillRect(20,20,160,160);
		Color c1=new Color(25,220,25);
		g.setColor(1);
		g.fillRect(40,40,120,120);
	}
}