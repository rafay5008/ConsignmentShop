namespace ConsignmentShopUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Text = new Label();
            itemslistBox = new ListBox();
            itemsListboxLabel = new Label();
            addtoCart = new Button();
            ShoppingCartListboxlabel = new Label();
            shoppingCartListbox = new ListBox();
            makePurchase = new Button();
            SuspendLayout();
            // 
            // Text
            // 
            Text.AutoSize = true;
            Text.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Text.Location = new Point(24, 9);
            Text.Name = "Text";
            Text.Size = new Size(265, 30);
            Text.TabIndex = 0;
            Text.Text = "Consignment Shop Demo";
            // 
            // itemslistBox
            // 
            itemslistBox.FormattingEnabled = true;
            itemslistBox.ItemHeight = 15;
            itemslistBox.Location = new Point(24, 102);
            itemslistBox.Name = "itemslistBox";
            itemslistBox.Size = new Size(159, 124);
            itemslistBox.TabIndex = 1;
            // 
            // itemsListboxLabel
            // 
            itemsListboxLabel.AutoSize = true;
            itemsListboxLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemsListboxLabel.Location = new Point(24, 84);
            itemsListboxLabel.Name = "itemsListboxLabel";
            itemsListboxLabel.Size = new Size(73, 15);
            itemsListboxLabel.TabIndex = 2;
            itemsListboxLabel.Text = "Store Items";
            // 
            // addtoCart
            // 
            addtoCart.Location = new Point(257, 152);
            addtoCart.Name = "addtoCart";
            addtoCart.Size = new Size(126, 35);
            addtoCart.TabIndex = 3;
            addtoCart.Text = "Add To Cart ->";
            addtoCart.UseVisualStyleBackColor = true;
            addtoCart.Click += addtoCart_Click;
            // 
            // ShoppingCartListboxlabel
            // 
            ShoppingCartListboxlabel.AutoSize = true;
            ShoppingCartListboxlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShoppingCartListboxlabel.Location = new Point(490, 84);
            ShoppingCartListboxlabel.Name = "ShoppingCartListboxlabel";
            ShoppingCartListboxlabel.Size = new Size(85, 15);
            ShoppingCartListboxlabel.TabIndex = 5;
            ShoppingCartListboxlabel.Text = "Shopping Cart";
            // 
            // shoppingCartListbox
            // 
            shoppingCartListbox.FormattingEnabled = true;
            shoppingCartListbox.ItemHeight = 15;
            shoppingCartListbox.Location = new Point(490, 102);
            shoppingCartListbox.Name = "shoppingCartListbox";
            shoppingCartListbox.Size = new Size(159, 124);
            shoppingCartListbox.TabIndex = 4;
            // 
            // makePurchase
            // 
            makePurchase.Location = new Point(570, 232);
            makePurchase.Name = "makePurchase";
            makePurchase.Size = new Size(79, 29);
            makePurchase.TabIndex = 6;
            makePurchase.Text = "Purchase";
            makePurchase.UseVisualStyleBackColor = true;
            // 
            // ConsignmentShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(makePurchase);
            Controls.Add(ShoppingCartListboxlabel);
            Controls.Add(shoppingCartListbox);
            Controls.Add(addtoCart);
            Controls.Add(itemsListboxLabel);
            Controls.Add(itemslistBox);
            Controls.Add(Text);
            Name = "ConsignmentShop";
            Text = "Consignment Form demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Text;
        private ListBox itemslistBox;
        private Label itemsListboxLabel;
        private Button addtoCart;
        private Label ShoppingCartListboxlabel;
        private ListBox shoppingCartListbox;
        private Button makePurchase;
    }
}
