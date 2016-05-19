package main.java.com.main;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 * Created by Mhamudul Hasan on 19/05/2016.
 */
public class TestGUI extends JFrame{
    private JPanel rootPanel;
    private JButton button1;

    public TestGUI() {

        button1.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                int reply = JOptionPane.showConfirmDialog(null, "message", "title", JOptionPane.YES_NO_OPTION);
                if (reply == JOptionPane.YES_OPTION) {
                    JOptionPane.showMessageDialog(null, "HELLO");
                }
                else {
                    JOptionPane.showMessageDialog(null, "GOODBYE");
                    // System.exit(0);
                }
            }
        });
    }
    private void createUIComponents() {
        // TODO: place custom component creation code here

    }
    public static void main(String[] args) {
        try{
            TestGUI testGUI=new TestGUI();

           // System.out.println("Hi in console");
            //JFrame frame = new JFrame("TestGUI");
            // frame.setSize(400, 400);
            testGUI.setContentPane(new TestGUI().rootPanel);
            testGUI.setSize(400,400);
            testGUI.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            //  frame.pack();

            testGUI.setVisible(true);
        }catch (Exception e)
        {
            System.out.println(e.toString());
            System.out.println(e.getStackTrace());
            JOptionPane.showConfirmDialog(null, "Error Not Succesful", "?????", JOptionPane.YES_NO_OPTION);

        }

    }
}
