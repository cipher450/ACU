Module Lang
    Sub English()

    End Sub
    Sub Franch()
        'Verf Form File : 

        With Verify_From_a_file
            .Label17.Text = "Chargement..."
            .CheckBox1.Text = "Détecter l'algorithme utilisé"
            .Label2.Text = "algorithme"
            .Button2.Text = "Annuler"
            .Button1.Text = "Vérifier"
            .Label1.Text = "Fichier : "
            .ColumnHeader1.Text = "Chemin du fichier"
            .ColumnHeader3.Text = "Résultat"
        End With

        'Result Dlg = 100%
        With resaultDlg
            .Label6.Text = "Ajouter un hash pour vérifier"

        End With

        'HashVerf : 100%

        With MultiHashVerify
            .CheckBox1.Text = "Afficher le Hash calculé"
            .Label1.Text = "Nom de fichier :"
            .Label4.Text = "Chemin :"
            .Label5.Text = "Chargement..."
            .Button1.Text = "Fermer"
            .Button2.Text = "Vérifier"
            .SaveAsToolStripMenuItem.Text = "Enregistrer l'icône"

        End With

        'Settings : 100%
        With Settings
            .TabPage1.Text = "Principale"
            .Label1.Text = "Choisissez votre langue :"
            .Label3.Text = "More options will be available in the next version "
            .Button4.Text = "Annuler"
            .Button3.Text = "Enregistrer"
            .Label3.Text = "Plus d'options seront disponibles dans la prochaine version"
        End With

        'Propr : 100%
        With Properties
            .Label1.Text = "Nom du fichier :"
            .Label8.Text = "Date de modification :"
            .Label9.Text = "Date de création : "
            .Label10.Text = "Version du fichier : "
            .Label11.Text = "Taille du fichier :"
            .Label12.Text = "Chemin complet :"
            .Label14.Text = "Attributs du fichier :"
            .CheckBox1.Text = "En majuscules"
            .Label17.Text = "Chargement..."
            .Button3.Text = "Enregistrer"
            .SaveAsToolStripMenuItem.Text = "Enregistrer l'icon"
        End With

        'Find Frm : 100%
        With Find
            .Text = "Trouver"
            .Label1.Text = "Recherche :"
            .Button1.Text = "Trouver"
            .Button2.Text = "Annuler"
            .CheckBox3.Text = "Préfixe"
            .CheckBox2.Text = "Inclure les sous-éléments"

        End With
        'Add Proc Frm  : 100%
        With Add_Process
            .Label1.Text = "Chargement"
            .ColumnHeader1.Text = "Nom du processus"
            .ColumnHeader8.Text = "Chemin complet"
            .AddToolStripMenuItem.Text = "Ajouter"
            .RefreshToolStripMenuItem.Text = "Rafraîchir"
            .CloseToolStripMenuItem.Text = "Fermer"
        End With
        'HashString Frm : 100%
        With HashString
            .Label4.Text = "Votre Text : "
            .Button1.Text = "Ajouter une Wordlist"
            .Button5.Text = "Tout effacer"
            .Button2.Text = "Enregister"
            .CheckBox7.Text = "Utiliser le HMAC"
            .GroupBox1.Text = " Résultat"
            .AddAWordToolStripMenuItem.Text = "Ajouter un mot"
            .RemoveSelectedToolStripMenuItem.Text = "Enlever la sélection"
            .ClearToolStripMenuItem.Text = "Effacer"
            .CopySelectedToolStripMenuItem.Text = "Copier la sélection "
            .Button3.Text = "Hashé"
            .LinkLabel2.Text = "Enregistrer "
            .LinkLabel1.Text = "importer"
            .CheckBox10.Text = "Majuscule"
            .Label7.Text = "Algorithme de hash :"
            .ToolStripMenuItem1.Text = "Enlever la sélection"
            .ClearToolStripMenuItem1.Text = "Effacer"
        End With

        'Main Form : 100%
        With Form1
            .NotifyIcon1.BalloonTipTitle = "Double-cliquez pour afficher ou masquer la Form"
            .ShowToolStripMenuItem.Text = "Montrer"
            .ExitToolStripMenuItem1.Text = "Quitter"
            .CopyCRC32ToolStripMenuItem1.Text = "Copier RIPEMD-160"
            .RIPEMD160ToolStripMenuItem.Text = "Copier RIPEMD-160"
            .FileToolStripMenuItem.Text = "Fichier"
            .AddFilesToolStripMenuItem.Text = "Ajouter des Fichier"
            .AddFilesToolStripMenuItem1.Text = "Ajouter des Fichier"
            .AddFolderToolStripMenuItem.Text = "Ajouter un Dossier"
            .AddFolderToolStripMenuItem1.Text = "Ajouter un Dossier"
            .AddProcessToolStripMenuItem.Text = "Ajouter un processus"
            .AddProsesToolStripMenuItem.Text = "Ajouter un processus"
            .EditToolStripMenuItem.Text = "Modifer"
            .FindToolStripMenuItem.Text = "Trouver"
            .CopyCRC32ToolStripMenuItem.Text = "Copier CRC32"
            .CopyCRC32ToolStripMenuItem2.Text = "Copier CRC32"
            .ViewToolStripMenuItem.Text = "Affichage"
            .CopyMD5ToolStripMenuItem.Text = "Copier MD5"
            .CopyMD5ToolStripMenuItem2.Text = "Copier MD5"
            .CopySHA1ToolStripMenuItem.Text = "Copier SHA"
            .icontray.Text = "Mettre l'icône sur le plateau"
            .AlwaysOnTop.Text = "Toujours en avant"
            .GridLines.Text = "Lignes de grille"
            .AutoResizeColumnsToolStripMenuItem.Text = "Redimensionnement automatique des colonnes"
            .QSToolStripMenuItem.Text = "Afficher les hachages en majuscules"
            .SettingsToolStripMenuItem.Text = "Paramètres"
            .SelectAllToolStripMenuItem.Text = "Tout sélectionner"
            .UnSelectAllToolStripMenuItem.Text = "Tout déselectionner"
            .ColumnHeader1.Text = "Nom de fichier"
            .ColumnHeader9.Text = "Chemin complet"
            .ColumnHeader10.Text = "Extension"
            .AboutToolStripMenuItem.Text = "À propos de..."
            .AboutToolStripMenuItem1.Text = "À propos de ACU 3.0"
            .Label1.Text = "Chargement..."
            .ToolStripStatusLabel4.Text = "Affichage"
            .ClearAllToolStripMenuItem.Text = "Effacer la liste"
            .RemoveSelectedItmeToolStripMenuItem.Text = "Supprimer l'élément sélectionné"
            .FsdToolStripMenuItem.Text = "Supprimer le fichier sélectionné"
            .OpenInVirusTotalToolStripMenuItem1.Text = "Ouvrir dans VirusTotal"
            .OpenInVirusTotalToolStripMenuItem.Text = "Ouvrir dans VirusTotal"
            .PropriToolStripMenuItem.Text = "Propriétés"
            .PropertiesToolStripMenuItem.Text = "Propriétés"
            .BasicToolStripMenuItem.Text = "De base"
            .AdvancedToolStripMenuItem.Text = "Avancée"
            .AdvancedToolStripMenuItem1.Text = "Avancée"
            .ToolStripMenuItem1.Text = "De base"
            .ExitToolStripMenuItem.Text = "Quitter"
            .CopyToolStripMenuItem.Text = "Copier"
            .CopySelectedItmeToolStripMenuItem2.Text = "Copier l'élément sélectionné"
            .CopySelectedItmeToolStripMenuItem.Text = "Copier l'élément sélectionné"
            .SaveToolStripMenuItem1.Text = "Enregistrer sous"
            .SaveToolStripMenuItem.Text = "Enregistrer sous"
            .VerifyToolStripMenuItem.Text = "Vérifier"
            .VerifySelectedToolStripMenuItem.Text = "Vérifier la sélection"
            .VerfyAllToolStripMenuItem.Text = "Vérifiez tout"
            .VerfyFromAFileToolStripMenuItem.Text = "Vérifier à partir d'un fichier"
            .RemoveToolStripMenuItem.Text = "Retirer"
            .SelectedItmeToolStripMenuItem.Text = "Fichier sélectionné"
            .ClearAllToolStripMenuItem1.Text = "Tout effacer"
            .SFVToolStripMenuItem.Text = "Fichier Checksum"
            .ToolStripMenuItem11.Text = "Fichier Checksum"
            .ToolStripMenuItem9.Text = "Enregistrer sélectionné"
            .ToolStripMenuItem10.Text = "Enregistrer Tout"
            .ToolStripMenuItem12.Text = "Enregistrer sélectionné"
            .ToolStripMenuItem13.Text = "Enregistrer Tout"
            .ToolStripMenuItem5.Text = "Enregistrer sélectionné"
            .ToolStripMenuItem4.Text = "Enregistrer Tout"
            .ToolStripMenuItem6.Text = "Enregistrer sélectionné"
            .ToolStripMenuItem7.Text = "Enregistrer Tout"
            .View_SmallIcon.Text = "Petite icône"
            .View_LargeIcon.Text = "Grande icône"
            .View_List.Text = "liste"
            .View_Details.Text = "Détails"
        End With

    End Sub
End Module
