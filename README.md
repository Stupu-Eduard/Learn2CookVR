# My First VR Project

Un proiect de Realitate Virtuală (VR) realizat în Unity folosind OpenXR și XR Interaction Toolkit. Aplicația este un mini-joc de bowling: jucătorul apucă o bilă, o aruncă pe pistă și încearcă să doboare cele 10 popice.

Când un popic se înclină peste un anumit unghi, scriptul îl marchează ca fiind căzut, îl colorează în verde, actualizează scorul afișat pe peretele din spate și îl face să dispară după scurt timp. Jocul poate fi testat și fără headset, folosind XR Device Simulator.

## Video Demo
https://github.com/user-attachments/assets/af9be4d1-1eaa-4b1b-a0ab-149c06ec5eb7

## Tehnologii folosite
* **Unity 3D** (versiunea 6.3 LTS)
* **OpenXR** (pentru runtime-ul VR)
* **XR Interaction Toolkit 3.3.2** (pentru Grab Interactable și interactori)
* **XR Device Simulator** (pentru testare fără headset)
* **TextMeshPro** (pentru afișarea scorului în UI)
* **C#** (pentru logica de detectare a popicelor căzute, scor și limitarea aruncărilor)

## Funcționalități principale
* **Apucarea și aruncarea obiectelor:** Bila de bowling poate fi prinsă și aruncată prin XR Grab Interactable.
* **Detectarea popicelor căzute:** Calculul înclinării fiecărui popic în timp real, cu feedback vizual (culoarea devine verde).
* **Scor în timp real:** Numărul de popice dărâmate este afișat pe un panou World Space TextMeshPro.
* **Efecte vizuale:** Sistem de particule (confetti) la STRIKE.
