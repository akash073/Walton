package main.java.com.main;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 * Created by Mhamudul Hasan on 19/05/2016.
 */
public class TestGUI {
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

    public static void main(String[] args) {
        JFrame frame = new JFrame("TestGUI");
        // frame.setSize(400, 400);
        frame.setContentPane(new TestGUI().rootPanel);
        frame.setSize(400,400);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        //  frame.pack();
        System.out.println("Hi in console");
        frame.setVisible(true);
    }
}
