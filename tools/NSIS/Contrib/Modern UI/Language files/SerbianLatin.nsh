;NSIS Modern User Interface - Language File
;Compatible with Modern UI 1.68

;Language: Serbian Latin (2074)
;By Vladan Obradovic and Sr�an Obu�ina <obucina@srpskijezik.edu.yu>

;--------------------------------

!insertmacro MUI_LANGUAGEFILE_BEGIN "SerbianLatin"

  !define MUI_LANGNAME "Serbian Latin" ;Use only ASCII characters (if this is not possible, use the English name)

  !define MUI_TEXT_WELCOME_INFO_TITLE "Dobrodo�li u instalacioni proces programa $(^NameDA)"
  !define MUI_TEXT_WELCOME_INFO_TEXT "Bi�ete vo�eni kroz proces instaliranja programa $(^NameDA).\r\n\r\nPreporu�livo je da isklju�ite sve druge programe pre po�etka instaliranja. Ovo mo�e omogu�iti a�uriranje sistemskih fajlova bez potrebe za restartovanjem ra�unara.\r\n\r\n$_CLICK"

  !define MUI_TEXT_LICENSE_TITLE "Dogovor o pravu kori��enja"
  !define MUI_TEXT_LICENSE_SUBTITLE "Pa�ljivo pro�itajte dogovor o pravu kori��enja pre instaliranja programa $(^NameDA)-e."
  !define MUI_INNERTEXT_LICENSE_TOP "Pritisnite Page Down da bi videli ostatak dogovora."
  !define MUI_INNERTEXT_LICENSE_BOTTOM "Ako prihvatate sve uslove dogovora, pritisnite dugme 'Prihvatam' za nastavak. Morate prihvatiti dogovor da bi instalirali program $(^NameDA)-u."
  !define MUI_INNERTEXT_LICENSE_BOTTOM_CHECKBOX "Ako prihvatate sve uslove dogovora, obele�ite kvadrati� ispod. Morate prihvatiti dogovor da bi instalirali program $(^NameDA)-u. $_CLICK"
  !define MUI_INNERTEXT_LICENSE_BOTTOM_RADIOBUTTONS "Ako prihvatate sve uslove dogovora, izaberite prvu opciju ispod. Morate prihvatiti dogovor da bi instalirali program $(^NameDA)-u. $_CLICK"

  !define MUI_TEXT_COMPONENTS_TITLE "Izbor komponenti za instaliranje"
  !define MUI_TEXT_COMPONENTS_SUBTITLE "Izaberite komponente za instaliranje. Instaliraju se samo ozna�ene komponente."
  !define MUI_INNERTEXT_COMPONENTS_DESCRIPTION_TITLE "Opis"
  !define MUI_INNERTEXT_COMPONENTS_DESCRIPTION_INFO "Pre�ite kursorom mi�a preko imena komponente da biste videli njen opis."

  !define MUI_TEXT_DIRECTORY_TITLE "Izbor direktorijuma za instaliranje"
  !define MUI_TEXT_DIRECTORY_SUBTITLE "Izaberite direktorijum u koji �ete instalirati program $(^NameDA)."

  !define MUI_TEXT_INSTALLING_TITLE "Instaliranje"
  !define MUI_TEXT_INSTALLING_SUBTITLE "Sa�ekajte dok se program $(^NameDA) instalira."

  !define MUI_TEXT_FINISH_TITLE "Zavr�eno instaliranje"
  !define MUI_TEXT_FINISH_SUBTITLE "Instaliranje je uspe�no zavr�eno."

  !define MUI_TEXT_ABORT_TITLE "Prekinuto instaliranje"
  !define MUI_TEXT_ABORT_SUBTITLE "Instaliranje je prekinuto i nije uspe�no zavr�eno."

  !define MUI_BUTTONTEXT_FINISH "Kraj"
  !define MUI_TEXT_FINISH_INFO_TITLE "Zavr�eno instaliranje programa $(^NameDA)"
  !define MUI_TEXT_FINISH_INFO_TEXT "Program $(^NameDA) je instaliran na ra�unar.\r\n\r\nPritisnite dugme 'Kraj' za zatvaranje ovog prozora."
  !define MUI_TEXT_FINISH_INFO_REBOOT "Ra�unar mora biti restartovan da bi se proces instaliranja programa $(^NameDA) uspe�no zavr�io. �elite li odmah da restartujete ra�unar?"
  !define MUI_TEXT_FINISH_REBOOTNOW "Restartuj odmah"
  !define MUI_TEXT_FINISH_REBOOTLATER "Bez restartovanja"
  !define MUI_TEXT_FINISH_RUN "Pokretanje programa $(^NameDA)"
  !define MUI_TEXT_FINISH_SHOWREADME "Prika�i Pro�itajMe fajl"

  !define MUI_TEXT_STARTMENU_TITLE "Izbor direktorijuma u Start meniju"
  !define MUI_TEXT_STARTMENU_SUBTITLE "Izaberite direktorijum u Start meniju u kome �e se kreirati pre�ice."
  !define MUI_INNERTEXT_STARTMENU_TOP "Izaberite direktorijum u Start meniju u kome �elite da budu kreirane pre�ice programa. Tako�e mo�ete upisati i ime za kreiranje novog direktorijuma."
  !define MUI_INNERTEXT_STARTMENU_CHECKBOX "Bez kreiranja pre�ica"

  !define MUI_TEXT_ABORTWARNING "Sigurno �elite da prekinete instaliranje programa $(^Name)?"


  !define MUI_UNTEXT_WELCOME_INFO_TITLE "Dobrodo�li u deinstaliranje programa $(^NameDA)"
  !define MUI_UNTEXT_WELCOME_INFO_TEXT "Bi�ete vo�eni kroz proces deinstaliranja programa $(^NameDA).\r\n\r\nPre po�etka deinstaliranja, uverite se da je program $(^NameDA) isklju�en. $_CLICK"

  !define MUI_UNTEXT_CONFIRM_TITLE "Deinstaliranje programa $(^NameDA)"
  !define MUI_UNTEXT_CONFIRM_SUBTITLE "Deinstaliranje programa $(^NameDA) sa ra�unara."

  !define MUI_UNTEXT_LICENSE_TITLE "Dogovor o pravu kori��enja"  
  !define MUI_UNTEXT_LICENSE_SUBTITLE "Pa�livo pro�itajte dogovor o pravu kori��enja pre deinstaliranja programa $(^NameDA)-e."
  !define MUI_UNINNERTEXT_LICENSE_BOTTOM "Ako prihvatate sve uslove dogovora, pritisnite dugme 'Prihvatam' za nastavak. Morate prihvatiti dogovor da bi deinstalirali program $(^NameDA)-u."
  !define MUI_UNINNERTEXT_LICENSE_BOTTOM_CHECKBOX "Ako prihvatate sve uslove dogovora, obele�ite kvadrati� ispod. Morate prihvatiti dogovor da bi deinstalirali program $(^NameDA)-u. $_CLICK"
  !define MUI_UNINNERTEXT_LICENSE_BOTTOM_RADIOBUTTONS "Ako prihvatate sve uslove dogovora, izaberite prvu opciju ispod. Morate prihvatiti dogovor da bi deinstalirali program $(^NameDA)-u. $_CLICK"

  !define MUI_UNTEXT_COMPONENTS_TITLE "Izbor komponenti za deinstaliranje"
  !define MUI_UNTEXT_COMPONENTS_SUBTITLE "Izaberite komponente za deinstaliranje. Deinstaliraju se samo ozna�ene komponente."

  !define MUI_UNTEXT_DIRECTORY_TITLE "Izbor direktorijuma za deinstaliranje"
  !define MUI_UNTEXT_DIRECTORY_SUBTITLE "Izaberite direktorijum iz koga �ete deinstalirati program $(^NameDA)."

  !define MUI_UNTEXT_UNINSTALLING_TITLE "Deinstaliranje"
  !define MUI_UNTEXT_UNINSTALLING_SUBTITLE "Sa�ekajte dok se program $(^NameDA) deinstalira."

  !define MUI_UNTEXT_FINISH_TITLE "Zavr�eno deinstaliranje"
  !define MUI_UNTEXT_FINISH_SUBTITLE "Deinstaliranje je uspe�no zavr�ena."
  
  !define MUI_UNTEXT_ABORT_TITLE "Prekinuto deinstaliranje"
  !define MUI_UNTEXT_ABORT_SUBTITLE "Deinstaliranje je prekinuto i nije uspe�no zavr�eno."

  !define MUI_UNTEXT_FINISH_INFO_TITLE "Zavr�eno deinstaliranje programa $(^NameDA)"
  !define MUI_UNTEXT_FINISH_INFO_TEXT "Program $(^NameDA) je deinstaliran sa ra�unara.\r\n\r\nPritisnite dugme 'Kraj' za zatvaranje ovog prozora."
  !define MUI_UNTEXT_FINISH_INFO_REBOOT "Ra�unar mora biti restartovan da bi zavr�ili deinstaliranje programa $(^NameDA). �elite li odmah da restartujete ra�unar?"

  !define MUI_UNTEXT_ABORTWARNING "Sigurno �elite da prekinete deinstaliranje programa $(^Name)?"

!insertmacro MUI_LANGUAGEFILE_END