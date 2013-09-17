#include "HttpCommonResource.h"

// temporary
const wchar_t*			HTTP_CLIENT_HOST_ADDRESS		= L"http://stg.book.dmkt-sp.jp/";

const wchar_t*			URI								= L"uri";
const wchar_t*			SESSION_ID						= L"session_id";
const wchar_t*			TITLE_ID						= L"title_id";
const wchar_t*			ITEM_ID							= L"item_id";
const wchar_t*			SAMPLE_FLG						= L"sample_flg";
const wchar_t*			CONNECTION_TIME_OUT				= L"CONNECTION_TIME_OUT";
const wchar_t*			SO_TIME_OUT						= L"SO_TIME_OUT";

const int				RESPONSE_CONNECTION				= 403;
const int				RESPONSE_TIMEOUT				= 408;
const int				RESPONSE_FAILED					= 400;
const int				RESPONSE_SIM_UNKNOWN			= 600;
const int				RESPONSE_NOT_SPACE				= 601;
const int				RESPONSE_AIRPLAIN_MODE			= 701;
const int				RESPONSE_UNMOUNT_MEDIA			= 702;

// StoreServerIF v0.99
const wchar_t*			ERROR_CODE_OK					= L"000";
const wchar_t*			ERROR_CODE_COOKIE_EXPIRED		= L"100";
const wchar_t*			ERROR_CODE_PARAMETER_ERROR		= L"101";
const wchar_t*			ERROR_CODE_NOT_PURCHASED		= L"102";
const wchar_t*			ERROR_CODE_DATA_NONE			= L"103";
const wchar_t*			ERROR_CODE_NULL_FILE			= L"104";
const wchar_t*			ERROR_CODE_DOWNLOAD_LIMIT		= L"105";
const wchar_t*			ERROR_CODE_FAILED				= L"400";
const wchar_t*			ERROR_CODE_REPARING				= L"401";
const wchar_t*			ERROR_CODE_NOT_IDENTICAL_IMEI	= L"402";
// old version
/*const wchar_t*			ERROR_CODE_AUTH_ERROR		= L"100";
const wchar_t*			ERROR_CODE_PARAMETER_ERROR 	= L"101";
const wchar_t*			ERROR_CODE_NOT_PURCHASED	= L"102";
const wchar_t*			ERROR_CODE_DATA_NONE		= L"103";
const wchar_t*			ERROR_CODE_FAILED			= L"400";*/

const wchar_t*			RESPONSE_HTTP_ERROR				= L"450";
const wchar_t*			RESPONSE_KEY_ERROR_CODE			= L"error-code";
const wchar_t*			RESPONSE_KEY_BODY				= L"response_body";
