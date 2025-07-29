# 🏅 Personalized Certificate Generator

Automated Certificate Generator and Email Sender for BBIT  
**Backend & UI: C# / WinForms**  
**Image Processing: Magick.NET**  
**Mail: SMTP (Gmail)**

---

## 📚 Table of Contents

- [About](#about)
- [Features](#features)
- [Requirements](#requirements)
- [Setup](#setup)
- [Usage](#usage)
- [How it Works](#how-it-works)
    - [Input CSV Format](#input-csv-format)
    - [Certificate Generation](#certificate-generation)
    - [Email Sending](#email-sending)
- [Screenshots](#screenshots)
- [Security Note](#security-note)
- [Troubleshooting](#troubleshooting)
- [Credits](#credits)
- [License](#license)

---

## 📝 About

**Auto Certificate Sender** streamlines and automates generating personalized certificates for students and sending them directly via email. Designed for events and workshops at BBIT, it saves hours of manual effort.

> **Author:** Akash Kumar (aka Devil/Aryan Kumar)  
> **College:** BBIT

---

## 🌟 Features

- Generate personalized certificates with custom fonts and layout.
- Process multiple students from a CSV list.
- Optional automatic email sending, with PDF or image attachments.
- Customizable email subject & message (with name placeholders).
- User-friendly Windows Forms UI.
- Status reporting and error handling.
- Extendable image processing functions (merge/overlay support).

---

## ⚙️ Requirements

- **.NET Framework** (>= 4.7.2 recommended)
- **Magick.NET** (Image processing)
- **WinForms**
- Gmail account (for SMTP; currently hardcoded—see [Security Note](#security-note))
- Required fonts (should be in the application directory or system)

---

## 🚀 Setup

1. **Clone the Repository**

    ```
    git clone https://github.com/godzaryan/auto-certificate-sender.git
    cd auto-certificate-sender
    ```

2. **Install Dependencies**

    - Restore NuGet packages (Magick.NET, System.Net.Mail if needed)
    - Make sure `Urbanist.ttf` font is available.

3. **Configure Email Credentials**

    - Currently, sender email & password are **hardcoded** (see `Functions` class).
    - For security, you should move these to a config file or use environment variables.

4. **Build & Run**

    - Open in Visual Studio, build the solution, and run.

---

## 🎮 Usage

1. Launch the program (`Auto_Certificate_Sender.exe`) after building.
2. **Provide a CSV file** with student data (see format below).
3. Configure options:
    - Enable/disable auto email sending.
    - Choose whether to attach the certificate.
    - Set custom subject and message (use `{name}` as a placeholder).
4. Click `Generate`!
5. Monitor progress/status on the UI.
6. Certificates are saved in the `Certificates` folder (auto-created).

---

### 📝 Input CSV Format

The input file should be a simple CSV:

full_name,email_address
Akash Kumar,akash@example.com
Devil,devil@example.com


- **No header row**
- Each line: `Name,Email`

---

### 🖼️ Certificate Generation

- Uses `template.jpg` as the certificate template.
- Personalizes the name using `Urbanist.ttf` (customizable in code).
- Output files: `Certificates/{Name}.jpg`
    - Ensure the `Certificates` directory exists or is writable.

---

### 📧 Email Sending

- If "Auto Send Email" is checked, an email is sent per record.
- Custom subject and message; `{name}` will be replaced dynamically.
- Optionally attach the generated certificate (`.jpg`).
- All mails are sent via the Gmail SMTP server (see [Security Note](#security-note)).

---

## 📸 Screenshots

<img width="586" height="505" alt="image" src="https://github.com/user-attachments/assets/fa1ce46f-6628-479a-a5b0-7d7813fd911b" />


---

## 🔐 Security Note

> **Warning:**  
> The sender email and password are **hardcoded** in the source (`Functions` class).  
> For security, use environment variables or a config file, especially if you publish or share the source code.

We recommend creating an **App Password** with Gmail (not your main account password) for SMTP.

---

## 🛠️ Troubleshooting

- **SMTP Errors:**  
  Make sure "Allow less secure apps" is enabled in Gmail, or preferably, use an App Password.
- **Font Not Found:**  
  Ensure `Urbanist.ttf` is in app directory or installed system-wide.
- **Attachment Skipped:**  
  Only `.jpg` files are attached. Ensure certificate generates successfully.

---

## ✨ Credits

- UI, Logic & Implementation: [Akash Kumar](mailto:cronoquillgamers2018@gmail.com) (Devil/Aryan Kumar)
- Magick.NET: [https://github.com/dlemstra/Magick.NET](https://github.com/dlemstra/Magick.NET)
- Thanks to BBIT, event organizers, and all contributors!

---

## 📜 License

MIT License (or add your preferred license)  
See [LICENSE](LICENSE) for details.
