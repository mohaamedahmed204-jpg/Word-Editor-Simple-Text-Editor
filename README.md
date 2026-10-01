# 📝 Word Editor (Simple Text Editor)

A feature-rich, customizable **C# Windows Forms Text Editor** application built with modern UI capabilities, dynamic theme switching (Dark & Light modes), custom ToolStrip renderers, and full text-processing functionality.

---

## 📸 Screenshots

| Dark Mode 🌙 | Light Mode ☀️ |
| :---: | :---: |
| ![Dark Mode](<img width="1168" height="792" alt="TestEditor_DarkMode" src="https://github.com/user-attachments/assets/8085bba5-d695-4cd4-9753-ac274ccb1c42" />) | ![Light Mode](<img width="1166" height="793" alt="TestEditor_LightMode" src="https://github.com/user-attachments/assets/9b9c1e75-7349-41c2-a7ed-9b8fab0237f5" />) |


---

## 🚀 Overview

**Word Editor** is an intuitive desktop word processing software designed using **C#** and **.NET Framework**. It offers essential text-editing capabilities combined with rich text formatting (RTF), customizable themes, word/character live counters, and file management features. 

The application provides custom UI renderers to ensure continuous visual consistency across menus, toolbars, and controls when switching between Light and Dark visual themes.

---

## 🛠️ Core Operations

* 📄 **File Operations:**
  * **New Document:** Resets the editor with a confirmation dialog to prevent accidental data loss.
  * **New Window:** Launches a new concurrent editor instance.
  * **Open File:** Supports loading standard text files (`.txt`) and Rich Text Format (`.rtf`) documents.
  * **Save As:** Allows saving text directly to `.rtf` or `.txt` formats using standard file dialogs.
  * **Exit:** Cleanly closes the active editor window.

* ✏️ **Edit & Manipulation Operations:**
  * **Undo / Redo:** Reverts or re-applies recent text editing operations.
  * **Clipboard Operations:** Full support for `Cut`, `Copy`, `Paste`, and `Delete`.
  * **Selection & Insertion:** Single-click `Select All` and current `Date/Time` insertion into the editor.

* 🎨 **Formatting & Styling:**
  * **Font & Color Customization:** Open standard Windows `FontDialog` and `ColorDialog` to style selected text.
  * **Text Styling Effects:** Toggle `Bold`, `Italic`, and `Underline` styles dynamically via bitwise XOR style toggling.
  * **Alignment Controls:** Align selected text to the `Left`, `Center`, or `Right`.
  * **Direction Support:** Quick alignment controls for `RTL` (Right-to-Left) and `LTR` (Left-to-Right) workflows.

* ⚙️ **View & Display Settings:**
  * **Dynamic Theme Switcher:** Instant transition between **Dark Mode** and **Light Mode**.
  * **Word Wrap Toggle:** Dynamically enables or disables text wrapping.
  * **Status Bar Toggle:** Show or hide the bottom status panel.
  * **Read-Only Mode:** Protects document content from unintended edits via a checkbox toggle.
  * **Live Counters:** Real-time character and word count calculations updated via text modification events.

---

## 🧠 Key Concepts Demonstrated

* **Custom WinForms Renderers:** Overriding `ToolStripProfessionalRenderer` (`MyFixedDarkRenderer` and `MyFixedLightRenderer`) to draw custom menu backgrounds, hover states, and margins that match the current color palette.
* **Preservation of RTF Formatting During Theme Switch:** Algorithms that selectively recalculate and update default text colors without wiping out user-defined text color choices.
* **Graphics & Layout Performance Optimization:** Utilizing `SuspendLayout()` and `ResumeLayout()` on `RichTextBox` controls during batch updates to eliminate visual screen flickering.
* **Event-Driven Architecture:** Delegating menu operations using tag-based routing (`item.Tag`) for modular code organization.
* **String Processing & Parsing:** Word-counting algorithm using string tokenization with multi-character delimiters (`' '`, `'\r'`, `'\n'`, `'\t'`).

---

## 🏗️ Architecture & Design

* **Modular Method Delegation:** Clean separation of concerns between file management (`OpenFile`, `SaveFile`), theme management (`ChangeMode`, `ApplyThemeToControls`), and editing events (`EditClick`, `FileClick`).
* **Tag-Based Menu Handling:** Unified event handlers for `File` and `Edit` menus, reducing boilerplate code by identifying actions through `ToolStripItem.Tag`.
* **Polymorphic UI Traversals:** Dynamic, recursive-style control traversal using `foreach(Control control in parent.Controls)` to recursively apply color themes to `Button`, `Label`, `Panel`, and `CheckBox` controls across complex layouts.

---

## 💻 Technologies

* **Language:** C#
* **Framework:** .NET Framework / Windows Forms (WinForms)
* **IDE:** Visual Studio Community
* **Graphics & UI:** GDI+ / `System.Drawing`, Custom `ToolStripRenderer`

---

## 🙏 Acknowledgments

This project is part of the Programming Advices Training Track led by:

* 👨‍🏫 Dr. Mohamed Abouhadhood
* 💻 Platform: Programming Advices
