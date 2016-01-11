;NSIS Modern User Interface - Language File
;Compatible with Modern UI 1.68

;Language: Luxembourgish (4103)
;By Jo Hoeser

;--------------------------------

!insertmacro MUI_LANGUAGEFILE_BEGIN "Luxembourgish"

  !define MUI_LANGNAME "L�tzeboiesch" ;Use only ASCII characters (if this is not possible, use the English name)

  !define MUI_TEXT_WELCOME_INFO_TITLE "W�llkomm beim Installatiouns-\r\nAssistent vun $(^NameDA)"
  !define MUI_TEXT_WELCOME_INFO_TEXT "Desen Assistent w�rt dech duech d'Installatioun vun $(^NameDA) begleeden.\r\n\r\nEt gett empfuel alleguer d'Programmer di am Moment laafen zouzemaan, datt bestemmt Systemdateien ouni Neistart ersaat kenne gin.\r\n\r\n$_CLICK"

  !define MUI_TEXT_LICENSE_TITLE "Lizenzoofkommes"
  !define MUI_TEXT_LICENSE_SUBTITLE "W.e.g. d'Lizenzoofkommes liesen, ierts de mat der Installatioun weiderfiers."
  !define MUI_INNERTEXT_LICENSE_TOP "Dr�ck d'PageDown-Tast fir den Rescht vum Oofkommes ze liesen."
  !define MUI_INNERTEXT_LICENSE_BOTTOM "Wanns de alleguer d'Bedengungen vum Oofkommes akzept�iers, klick op Unhuelen. Du muss alleguer d'Fuerderungen unerkennen, fir $(^NameDA) install�ieren ze kennen."
  !define MUI_INNERTEXT_LICENSE_BOTTOM_CHECKBOX "Wanns de alleguer d'Bedengungen vum Oofkommes akzept�iers, aktiv�ier d'Keschtchen. Du muss alleguer d'Fuerderungen unerkennen, fir $(^NameDA) install�ieren ze kennen. $_CLICK"
  !define MUI_INNERTEXT_LICENSE_BOTTOM_RADIOBUTTONS "Wanns de alleguer d'Bedengungen vum Oofkommes akzept�iers, wiel ennen di entspriechend �ntwert. Du muss alleguer d'Fuerderungen unerkennen, fir $(^NameDA) install�ieren ze kennen. $_CLICK"

  !define MUI_TEXT_COMPONENTS_TITLE "Komponenten auswielen"
  !define MUI_TEXT_COMPONENTS_SUBTITLE "Wiel d'Komponenten aus, d�is de wells install�ieren."
  !define MUI_INNERTEXT_COMPONENTS_DESCRIPTION_TITLE "Beschreiwung"
  !define MUI_INNERTEXT_COMPONENTS_DESCRIPTION_INFO "Haal den Mausfeil iwwer eng Komponent, fir d'Beschreiwung dervun ze gesin."

  !define MUI_TEXT_DIRECTORY_TITLE "Zielverzeechnes auswielen"
  !define MUI_TEXT_DIRECTORY_SUBTITLE "Wiel den Dosssier aus, an deen $(^NameDA) install�iert gin soll."

  !define MUI_TEXT_INSTALLING_TITLE "Install�ieren..."
  !define MUI_TEXT_INSTALLING_SUBTITLE "Waard w.e.g w�hrend deem $(^NameDA) install�iert gett."

  !define MUI_TEXT_FINISH_TITLE "Installatioun f�rdeg"
  !define MUI_TEXT_FINISH_SUBTITLE "D'Installatioun ass ordnungsgem�� oofgeschloss gin."

  !define MUI_TEXT_ABORT_TITLE "Installation oofgebrach"
  !define MUI_TEXT_ABORT_SUBTITLE "D'Installation ass net komplett oofgeschloss gin."

  !define MUI_BUTTONTEXT_FINISH "&Ferdeg maan"
  !define MUI_TEXT_FINISH_INFO_TITLE "D'Installatioun vun $(^NameDA) gett oofgeschloss."
  !define MUI_TEXT_FINISH_INFO_TEXT "$(^NameDA) ass um Computer install�iert gin.\r\n\r\nKlick op f�rdeg maan, fir den Installatiouns-Assistent zou ze maan.."
  !define MUI_TEXT_FINISH_INFO_REBOOT "Den Windows muss n�i gestart gin, fir d'Installatioun vun $(^NameDA) oofzeschl�issen. Wells de Windows lo n�i starten?"
  !define MUI_TEXT_FINISH_REBOOTNOW "Lo n�i starten"
  !define MUI_TEXT_FINISH_REBOOTLATER "Sp�ider manuell n�i starten"
  !define MUI_TEXT_FINISH_RUN "$(^NameDA) op maan"
  !define MUI_TEXT_FINISH_SHOWREADME "Liesmech op maan"

  !define MUI_TEXT_STARTMENU_TITLE "Startmen�-Dossier best�mmen"
  !define MUI_TEXT_STARTMENU_SUBTITLE "Best�mm een Startman�-Dossier an deen d'Programmoofkierzungen kommen."
  !define MUI_INNERTEXT_STARTMENU_TOP "Best�mm een Startman�-Dossier an deen d'Programmoofkierzungen kommen. Wanns de een n�ien Dossier maan wells, geff deem s�in zuk�nftegen Numm an."
  !define MUI_INNERTEXT_STARTMENU_CHECKBOX "Keng Oofkierzungen maan"

  !define MUI_TEXT_ABORTWARNING "Bas de secher, dass de d'Installatioun vun $(^Name) oofbriechen wells?"


  !define MUI_UNTEXT_WELCOME_INFO_TITLE "W�llkomm am Desinstallatiouns-\r\n\Assistent f�r $(^NameDA)"
  !define MUI_UNTEXT_WELCOME_INFO_TEXT "Desen Assistent begleet dech duech d'Desinstallatioun vun $(^NameDA).\r\n\r\nW.e.g. maach $(^NameDA) zu, ierts de mat der Desinstallatioun uf�nks.\r\n\r\n$_CLICK"

  !define MUI_UNTEXT_CONFIRM_TITLE "Desinstallatioun vun $(^NameDA)"
  !define MUI_UNTEXT_CONFIRM_SUBTITLE "$(^NameDA) gett vum Computer desinstall�iert."

  !define MUI_UNTEXT_LICENSE_TITLE "Lizenzoofkommes"
  !define MUI_UNTEXT_LICENSE_SUBTITLE "W.e.g. lies d'Lizenzoofkommes duech ierts de mat der Desinstallatioun vun $(^NameDA) w�iderfiers."
  !define MUI_UNINNERTEXT_LICENSE_BOTTOM "Wanns de d'Fuerderungen vum Oofkommes akzept�iers, klick op unhuelen. Du muss d'Oofkommes akzept�ieren, fir $(^NameDA) kennen ze desinstall�ieren."
  !define MUI_UNINNERTEXT_LICENSE_BOTTOM_CHECKBOX "Wanns de d'Fuerderungen vum Oofkommes akzept�iers, aktiv�ier d'Keschtchen. Du muss d'Oofkommes akzept�ieren, fir $(^NameDA) kennen ze desinstall�ieren. $_CLICK"
  !define MUI_UNINNERTEXT_LICENSE_BOTTOM_RADIOBUTTONS "Wanns de d'Fuerderungen vum Oofkommes akzept�iers, wiel ennen di entspriechend Optioun. Du muss d'Oofkommes akzept�ieren, fir $(^NameDA) kennen ze desinstall�ieren. $_CLICK"

  !define MUI_UNTEXT_COMPONENTS_TITLE "Komponenten auswielen"
  !define MUI_UNTEXT_COMPONENTS_SUBTITLE "Wiel eng Komponent aus, d�is de desinstall�ieren wells."

  !define MUI_UNTEXT_DIRECTORY_TITLE "Dossier fir d'Desinstallatioun wielen"
  !define MUI_UNTEXT_DIRECTORY_SUBTITLE "Wiel den Dossier aus, aus dem $(^NameDA) desinstall�iert gin soll."

  !define MUI_UNTEXT_UNINSTALLING_TITLE "Desinstall�ieren..."
  !define MUI_UNTEXT_UNINSTALLING_SUBTITLE "W.e.g. waard, w�hrend deems $(^NameDA) desinstall�iert gett."

  !define MUI_UNTEXT_FINISH_TITLE "Desinstallatioun oofgeschloss"
  !define MUI_UNTEXT_FINISH_SUBTITLE "D'Desinstallatioun ass erfolegr�ich oofgeschloss gin."

  !define MUI_UNTEXT_ABORT_TITLE "Desinstallatioun oofbriechen"
  !define MUI_UNTEXT_ABORT_SUBTITLE "D'Desinstallatioun ass net erfolegr�ich oofgeschloss gin."

  !define MUI_UNTEXT_FINISH_INFO_TITLE "D'Desinstallatioun vun $(^NameDA) gett oofgeschloss"
  !define MUI_UNTEXT_FINISH_INFO_TEXT "$(^NameDA) ass vum Computer desinstall�iert gin.\r\n\r\nKlick op Oofschl�issen fir den Assistent zou ze maan."
  !define MUI_UNTEXT_FINISH_INFO_REBOOT "Windows muss n�i gestart gin, fir d'Desinstallatioun vun $(^NameDA) ze vervollst�nnegen. Wells de Windows lo n�i starten?"

  !define MUI_UNTEXT_ABORTWARNING "Bas de secher, dass de d'Desinstallatioun vun $(^Name) oofbriechen wells?"

!insertmacro MUI_LANGUAGEFILE_END