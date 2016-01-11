#include <windows.h>
#include "resource.h"

// JF> updated usage
// call like this:
// LangDLL:LangDialog "Window Title" "Window subtext" <number of languages>[F] language_text language_id ... [font_size font_face]
// ex:
//  LangDLL:LangDialog "Language Selection" "Choose a language" 2 French 1036 English 1033
// or (the F after the 2 means we're supplying font information)
//  LangDLL:LangDialog "Language Selection" "Choose a language" 2F French 1036 English 1033 12 Garamond


#include "../exdll/exdll.h"

int myatoi(char *s);

HINSTANCE g_hInstance;
HWND g_hwndParent;

char temp[1024];
char g_wndtitle[1024], g_wndtext[1024];
int dofont;

int langs_num;

struct lang {
  char *name;
  char *id;
} *langs;

BOOL CALLBACK DialogProc(HWND hwndDlg, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
  int i, size;
  static HFONT font;
  switch (uMsg) {
  	case WM_INITDIALOG:
      for (i = langs_num - 1; i >= 0; i--) {
        SendDlgItemMessage(hwndDlg, IDC_LANGUAGE, CB_ADDSTRING, 0, (LPARAM)langs[i].name);
      }
      SetDlgItemText(hwndDlg, IDC_TEXT, g_wndtext);
      SetWindowText(hwndDlg, g_wndtitle);
      SendDlgItemMessage(hwndDlg, IDC_APPICON, STM_SETICON, (LPARAM)LoadIcon(GetModuleHandle(0),MAKEINTRESOURCE(103)), 0);
      for (i = 0; i < langs_num; i++) {
        if (!lstrcmp(langs[i].id, getuservariable(INST_LANG))) {
          SendDlgItemMessage(hwndDlg, IDC_LANGUAGE, CB_SETCURSEL, langs_num-i-1, 0);
          break;
        }
      }
      if (dofont && !popstring(temp))
      {
        size = myatoi(temp);
        if (!popstring(temp)) {
          LOGFONT f = {0,};
          if (lstrcmp(temp, "MS Shell Dlg")) {
            f.lfHeight = -MulDiv(size, GetDeviceCaps(GetDC(hwndDlg), LOGPIXELSY), 72);
            lstrcpy(f.lfFaceName, temp);
            font = CreateFontIndirect(&f);
            SendMessage(hwndDlg, WM_SETFONT, (WPARAM)font, 1);
            SendDlgItemMessage(hwndDlg, IDOK, WM_SETFONT, (WPARAM)font, 1);
            SendDlgItemMessage(hwndDlg, IDCANCEL, WM_SETFONT, (WPARAM)font, 1);
            SendDlgItemMessage(hwndDlg, IDC_LANGUAGE, WM_SETFONT, (WPARAM)font, 1);
            SendDlgItemMessage(hwndDlg, IDC_TEXT, WM_SETFONT, (WPARAM)font, 1);
          }
        }
      }
      ShowWindow(hwndDlg, SW_SHOW);
      break;
    case WM_COMMAND:
      switch (LOWORD(wParam)) {
      	case IDOK:
          pushstring(langs[langs_num-SendDlgItemMessage(hwndDlg, IDC_LANGUAGE, CB_GETCURSEL, 0, 0)-1].id);
          EndDialog(hwndDlg, 0);
          break;
        case IDCANCEL:
          pushstring("cancel");
          EndDialog(hwndDlg, 1);
          break;
      }
      break;
    case WM_CLOSE:
      if (font) DeleteObject(font);
      pushstring("cancel");
      EndDialog(hwndDlg, 1);
      break;
    default:
      return 0;
  }
  return 1;
}

void __declspec(dllexport) LangDialog(HWND hwndParent, int string_size, 
                                      char *variables, stack_t **stacktop)
{
  g_hwndParent=hwndParent;
  EXDLL_INIT();

  {
    int i;
    BOOL bPopOneMore = FALSE;

    if (popstring(g_wndtitle)) return;
    if (popstring(g_wndtext)) return;

    if (popstring(temp)) return;
    if (*temp == 'A')
    {
      stack_t *th;
      langs_num=0;
      th=(*g_stacktop);
      while (th && th->text[0]) {
        langs_num++;
        th = th->next;
      }
      if (!th) return;
      langs_num /= 2;
      bPopOneMore = TRUE;
    }
    else
      langs_num = myatoi(temp);
    {
      char *p=temp;
      while (*p) if (*p++ == 'F') dofont=1;
    }

    if (!langs_num) return;

    langs = (struct lang *)GlobalAlloc(GPTR, langs_num*sizeof(struct lang));

    for (i = 0; i < langs_num; i++) {
      if (popstring(temp)) return;
      langs[i].name = GlobalAlloc(GPTR, lstrlen(temp)+1);
      lstrcpy(langs[i].name, temp);

      if (popstring(temp)) return;
      langs[i].id = GlobalAlloc(GPTR, lstrlen(temp)+1);
      lstrcpy(langs[i].id, temp);
    }
    if (bPopOneMore) {
      if (popstring(temp)) return;
    }

    DialogBox(g_hInstance, MAKEINTRESOURCE(IDD_DIALOG), 0, DialogProc);
  }
}

BOOL WINAPI DllMain(HANDLE hInst, ULONG ul_reason_for_call, LPVOID lpReserved)
{
  g_hInstance=hInst;
	return TRUE;
}

int myatoi(char *s)
{
  unsigned int v=0;
  for (;;)
  {
    int c=*s++ - '0';
    if (c < 0 || c > 9) break;
    v*=10;
    v+=c;
  }
  return (int)v;
}