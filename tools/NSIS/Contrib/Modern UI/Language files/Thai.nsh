;NSIS Modern User Interface - Language File
;Compatible with Modern UI 1.63

;Language: Thai (1054)
;By TuW@nNu tuwannu@hotmail.com (asdfuae)

;--------------------------------

!insertmacro MUI_LANGUAGEFILE_BEGIN "Thai"

  !define MUI_LANGNAME "Thai" ;(������) Use only ASCII characters (if this is not possible, use the English name)

  !define MUI_TEXT_WELCOME_INFO_TITLE "�Թ�յ�͹�Ѻ�������õԴ�������� $(^NameDA) "
  !define MUI_TEXT_WELCOME_INFO_TEXT "��ǵԴ��駹��еԴ�������� $(^NameDA) ŧ������������ͧ�س\r\n\r\n�ҧ��Ң��й����Դ�����������������͹����������Դ��� ��е�ǵԴ��駹������ͧ��á���պٵ����ͧ����\r\n\r\n$_CLICK"
  
  !define MUI_TEXT_LICENSE_TITLE "��͵�ŧ����ͧ�Ԣ�Է���"  
  !define MUI_TEXT_LICENSE_SUBTITLE "��س���ҹ��͵�ŧ��ҹ�Ԣ�Է����͹�Դ�������� $(^NameDA)."
  !define MUI_INNERTEXT_LICENSE_TOP "������ Page Down ������ҹ��������´��������"
  !define MUI_INNERTEXT_LICENSE_BOTTOM "��Ҥس����Ѻ㹢�͵�ŧ��� ��سҡ����� ����Ѻ ��Фس�е�ͧ��ŧ��͹����������Դ�������� $(^NameDA)."
  
  !define MUI_TEXT_COMPONENTS_TITLE "���͡����๹��"
  !define MUI_TEXT_COMPONENTS_SUBTITLE "���͡ features �ͧ $(^NameDA) ���س��ͧ��õԴ���"
  !define MUI_INNERTEXT_COMPONENTS_TOP "�������ͧ���¶١˹����觷��س��ͧ��õԴ�������������ͧ���¶١�͡˹����觷��س����ͧ��õԴ���"
  !define MUI_INNERTEXT_COMPONENTS_DESCRIPTION_TITLE "��������´"
  !define MUI_INNERTEXT_COMPONENTS_DESCRIPTION_INFO "����͹�����仺����ͤ���๹�����ʹ���������´"
  
  !define MUI_TEXT_DIRECTORY_TITLE "���͡���������Դ���"
  !define MUI_TEXT_DIRECTORY_SUBTITLE "���͡���������ͧ������Դ���ŧ $(^NameDA)."
  !define MUI_INNERTEXT_DIRECTORY_TOP "���ѧ���еԴ�������� $(^NameDA) ŧ��������ҹ��ҧ���$\r$\n$\r$\n�ҡ�س��ͧ������Դ���ŧ��������蹡�سҤ��꡻������¡���������͡���������ͧ���"
  !define MUI_INNERTEXT_DIRECTORY_DESTINATION "������ش����"
  
  !define MUI_TEXT_INSTALLING_TITLE "���ѧ�Դ���"
  !define MUI_TEXT_INSTALLING_SUBTITLE "��س����ѡ���������ҧ����� $(^NameDA) ���ѧ�Դ�������"
  
  !define MUI_TEXT_FINISH_TITLE "�Դ������º����"
  !define MUI_TEXT_FINISH_SUBTITLE "��õԴ�����������ó�����"
  !define MUI_BUTTONTEXT_FINISH "&�������"
  !define MUI_TEXT_FINISH_INFO_TITLE "���ѧ���Թ������¡������Դ��� $(^NameDA) "
  !define MUI_TEXT_FINISH_INFO_TEXT "$(^NameDA) �١�Դ������º��������\r\n\r\n���꡻��� ������� �����͡�ҡ�����"
  !define MUI_TEXT_FINISH_INFO_REBOOT "����ͧ�ͧ�س��ͧ��á���պٵ��ѧ�ҡ�Դ��� $(^NameDA). �س��ͧ��÷����պٵ����������"
  !define MUI_TEXT_FINISH_REBOOTNOW "�պٵ"
  !define MUI_TEXT_FINISH_REBOOTLATER "�պٵ����ѧ"
  !define MUI_TEXT_FINISH_RUN "�Դ����� $(^NameDA)"
  !define MUI_TEXT_FINISH_SHOWREADME "��ҹ Readme"
  
  !define MUI_TEXT_STARTMENU_TITLE "���͡������ Start ����"
  !define MUI_TEXT_STARTMENU_SUBTITLE "���͡������ Start ���ٷ���ͧ������ҧ�Ѵ�ͧ�������������"
  !define MUI_INNERTEXT_STARTMENU_TOP "���͡���� Start ���س��ͧ������ҧ�Ѵ�ͧ���������� �������ҧ��������������"
  !define MUI_INNERTEXT_STARTMENU_CHECKBOX "����ͧ���ҧ�ҧ�Ѵ"
  
  !define MUI_TEXT_ABORTWARNING "�س��������������͡�ҡ������Դ��� $(^Name) "  
  
  
  !define MUI_UNTEXT_CONFIRM_TITLE "ź����� $(^NameDA) �͡�ҡ����ͧ"
  !define MUI_UNTEXT_CONFIRM_SUBTITLE "ź����� $(^NameDA) �͡�ҡ����ͧ�ͧ�س"
  
  !define MUI_UNTEXT_UNINSTALLING_TITLE "���ѧź"
  !define MUI_UNTEXT_UNINSTALLING_SUBTITLE "��س��͢�з�� $(^NameDA) ���ѧ�١ź"
    
  !define MUI_UNTEXT_FINISH_TITLE "���º����"
  !define MUI_UNTEXT_FINISH_SUBTITLE "���ź�������������ó�����"
  
!insertmacro MUI_LANGUAGEFILE_END