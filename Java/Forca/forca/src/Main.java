
import java.awt.event.KeyEvent;
import java.util.Arrays;
import java.util.regex.Pattern;
import javax.swing.JOptionPane;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author samhi
 */
public class Main extends javax.swing.JFrame {
    String ent;
    char l;
    char []a;
    char []b;
    int vida, img;
            
    
    public Main() {
        initComponents();
        this.setLocationRelativeTo(null);
        vida = 6;
        img = 0;
        ent = JOptionPane.showInputDialog("Digite uma palavra: ").toLowerCase();
        if (Pattern.compile("[1-9]").matcher(ent).find() || Pattern.compile("[\"'!@#$%¨&*()-_+§=/°?;:.>,<\\|[{]}ºª¹²³£¢¬]").matcher(ent).find()) {
            while(Pattern.compile("[1-9]").matcher(ent).find() || Pattern.compile("[\"'!@#$%¨&*()-_+§=/°?;:.>,<\\|[{]}ºª¹²³£¢¬]").matcher(ent).find()){
                ent = JOptionPane.showInputDialog("Digite uma palavra sem números ou caracteres especiais: ").toLowerCase();
            }
        }
        lblNum.setText(Integer.toString(ent.length()));
        a = new char [ent.length()];
        b = ent.toCharArray();
        for (int i = 0; i < ent.length(); i++) {
            a[i] = '_';
            lblPalavra.setText(lblPalavra.getText() + a[i] + " ");
        }
    }

    public void novo(){
        ent = "";
        lblLUsadas.setText("");
        lblPalavra.setText("");
        lblResult.setText("");
        a = null;
        b = null;
        vida = 6;
        img = 0;
        pic.setIcon(null);
        txtEntrada.setEnabled(true);
        btn.setEnabled(true);
        ent = JOptionPane.showInputDialog("Digite uma palavra: ").toLowerCase();
        if (Pattern.compile("[1-9]").matcher(ent).find() || Pattern.compile("[\"'!@#$%¨&*()-_+§=/°?;:.>,<\\|[{]}ºª¹²³£¢¬]").matcher(ent).find()) {
            while(Pattern.compile("[1-9]").matcher(ent).find() || Pattern.compile("[\"'!@#$%¨&*()-_+§=/°?;:.>,<\\|[{]}ºª¹²³£¢¬]").matcher(ent).find()){
                ent = JOptionPane.showInputDialog("Digite uma palavra sem números ou caracteres especiais: ").toLowerCase();
            }
        }
        lblNum.setText(Integer.toString(ent.length()));
        a = new char [ent.length()];
        b = ent.toCharArray();
        for (int i = 0; i < ent.length(); i++) {
            a[i] = '_';
            lblPalavra.setText(lblPalavra.getText() + a[i] + " ");
        }
    }
    
    public void acerto(){
        boolean vf = false;
        lblPalavra.setText("");
        for (int i = 0; i < a.length; i++) {
            if (b[i] == l) {
                a[i] = l;
                lblPalavra.setText(lblPalavra.getText() + a[i] + " ");
            }else{
                lblPalavra.setText(lblPalavra.getText() + a[i] + " ");
            }
        }
        if (!Arrays.toString(a).contains("_")) {
            lblResult.setText("Ganhou!");
            txtEntrada.setEnabled(false);
            btn.setEnabled(false);
        }
    }
    
    public void erro(){
        img++;
        lblLUsadas.setText(lblLUsadas.getText() + l + " ");
        vida--;
        pic.setIcon(new javax.swing.ImageIcon("T:\\Usuarios\\INFORMATICA\\3AETIM\\TURMA B\\Jv e Zamuel\\3INFO-JVT\\Java\\Forca\\Imagens\\" + img + ".png"));
        if (vida == 0) {
            lblResult.setText("Perdeu!");
            lblPalavra.setText(lblPalavra.getText() + " - " + ent);
            txtEntrada.setEnabled(false);
            btn.setEnabled(false);
        }
    }
        
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pic = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        lblResult = new javax.swing.JLabel();
        lblPalavra = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        lblLUsadas = new javax.swing.JLabel();
        txtEntrada = new javax.swing.JTextField();
        btn = new javax.swing.JButton();
        jLabel4 = new javax.swing.JLabel();
        lblNum = new javax.swing.JLabel();
        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();
        jMenu2 = new javax.swing.JMenu();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setResizable(false);

        pic.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));
        pic.setPreferredSize(new java.awt.Dimension(106, 232));

        jLabel3.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        jLabel3.setText("Palavra : ");

        lblPalavra.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        lblPalavra.setBorder(javax.swing.BorderFactory.createEtchedBorder());

        jLabel2.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        jLabel2.setText("Letras erradas : ");

        lblLUsadas.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        lblLUsadas.setBorder(javax.swing.BorderFactory.createEtchedBorder());

        txtEntrada.setFont(new java.awt.Font("Century Gothic", 0, 36)); // NOI18N
        txtEntrada.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtEntrada.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtEntradaKeyPressed(evt);
            }
        });

        btn.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btn.setText("Enviar");
        btn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnActionPerformed(evt);
            }
        });

        jLabel4.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        jLabel4.setText("Digite uma letra :");

        jMenu1.setLabel("Novo Jogo");
        jMenu1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jMenu1MouseClicked(evt);
            }
        });
        jMenuBar1.add(jMenu1);

        jMenu2.setLabel("Sair");
        jMenu2.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jMenu2MouseClicked(evt);
            }
        });
        jMenuBar1.add(jMenu2);

        setJMenuBar(jMenuBar1);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(6, 6, 6)
                .addComponent(pic, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel3)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(lblNum, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(lblResult, javax.swing.GroupLayout.PREFERRED_SIZE, 64, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(lblPalavra, javax.swing.GroupLayout.PREFERRED_SIZE, 274, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel2)
                    .addComponent(lblLUsadas, javax.swing.GroupLayout.PREFERRED_SIZE, 274, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                            .addComponent(txtEntrada, javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel4, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addGap(18, 18, 18)
                        .addComponent(btn, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                .addGap(0, 4, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                            .addComponent(lblResult, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jLabel3, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(lblNum, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(lblPalavra, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jLabel2)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(lblLUsadas, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jLabel4)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txtEntrada, javax.swing.GroupLayout.PREFERRED_SIZE, 49, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(btn, javax.swing.GroupLayout.PREFERRED_SIZE, 49, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addComponent(pic, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        jLabel2.getAccessibleContext().setAccessibleName("Letras erradas : ");

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnActionPerformed
        txtEntrada.requestFocus();
        if (!(txtEntrada.getText().isEmpty() || Pattern.compile("[1-9]").matcher(txtEntrada.getText()).find() || txtEntrada.getText().length() > 1)) {
                l = txtEntrada.getText().toLowerCase().charAt(0);
                if (Arrays.toString(a).contains(txtEntrada.getText()) || lblLUsadas.getText().contains(txtEntrada.getText())) {
                    JOptionPane.showMessageDialog(null, "A letra já foi digitada.");
                    txtEntrada.setText("");
                }else{
                    if (ent.contains(txtEntrada.getText())) {
                        txtEntrada.setText("");
                        acerto();
                    }else{
                        txtEntrada.setText("");
                        erro();
                    }
                }
        }else{ 
            JOptionPane.showMessageDialog(null, "Digite uma letra!");
        }
    }//GEN-LAST:event_btnActionPerformed

    private void jMenu2MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jMenu2MouseClicked
        System.exit(0);
    }//GEN-LAST:event_jMenu2MouseClicked

    private void jMenu1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jMenu1MouseClicked
        novo();
    }//GEN-LAST:event_jMenu1MouseClicked

    private void txtEntradaKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtEntradaKeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            btn.doClick();
        }
    }//GEN-LAST:event_txtEntradaKeyPressed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException | InstantiationException | IllegalAccessException | javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Main.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(() -> {
            new Main().setVisible(true);
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btn;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenu jMenu2;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JLabel lblLUsadas;
    private javax.swing.JLabel lblNum;
    private javax.swing.JLabel lblPalavra;
    private javax.swing.JLabel lblResult;
    private javax.swing.JLabel pic;
    private javax.swing.JTextField txtEntrada;
    // End of variables declaration//GEN-END:variables
}
