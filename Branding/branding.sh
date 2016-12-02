#!/bin/sh

#the local revision numbers are the same as the local revision numbers on the remote repository;
#also we know that xenadmin.git is not a patch queue style repository
BRANDING_CSET_NUMBER=$(cd ${REPO} && git rev-list HEAD -1 && echo "")

# bring versions from the server branding repo
ROOT="$( cd -P "$( dirname "${BASH_SOURCE[0]}" )/../.." && pwd )"

rm -rf ${ROOT}/branding.git
BRANDING_REMOTE=https://code.citrite.net/scm/xs/branding.git

if [ -z $(git ls-remote --heads ${BRANDING_REMOTE} | grep ${XS_BRANCH}) ] ; then
    echo "Branch ${XS_BRANCH} not found on branding.git. Reverting to master."
    git clone -b master ${BRANDING_REMOTE} ${ROOT}/branding.git
else
    git clone -b ${XS_BRANCH} ${BRANDING_REMOTE} ${ROOT}/branding.git
fi

TOPLEVEL_VERSIONS=${ROOT}/branding.git/Citrix/XenServer/toplevel-versions
TOPLEVEL_BRANDING=${ROOT}/branding.git/Citrix/XenServer/toplevel-branding

BRANDING_COMPANY_NAME_LEGAL=$(cat ${TOPLEVEL_BRANDING} | grep -F "COMPANY_NAME_LEGAL := " | sed -e 's/COMPANY_NAME_LEGAL := //g')
BRANDING_COMPANY_NAME_SHORT=$(cat ${TOPLEVEL_BRANDING} | grep -F "COMPANY_NAME_SHORT := " | sed -e 's/COMPANY_NAME_SHORT := //g')
BRANDING_COPYRIGHT=\"Copyright\ ©\ ${BRANDING_COMPANY_NAME_LEGAL}\"
BRANDING_COPYRIGHT_2=\"Copyright\ \\\\251\ ${BRANDING_COMPANY_NAME_LEGAL}\"
BRANDING_PRODUCT_BRAND=$(cat ${TOPLEVEL_BRANDING} | grep -F "PRODUCT_BRAND := " | sed -e 's/PRODUCT_BRAND := //g')
BRANDING_COMPANY_URL=www.$(cat ${TOPLEVEL_BRANDING} | grep -F "COMPANY_DOMAIN := " | sed -e 's/COMPANY_DOMAIN := //g')
BRANDING_PRODUCT_VERSION_TEXT=$(cat ${TOPLEVEL_VERSIONS} | grep -F "PRODUCT_VERSION_TEXT := " | sed -e 's/PRODUCT_VERSION_TEXT := //g')
BRANDING_PRODUCT_MAJOR_VERSION=$(cat ${TOPLEVEL_VERSIONS} | grep -F "PRODUCT_MAJOR_VERSION := " | sed -e 's/PRODUCT_MAJOR_VERSION := //g')
BRANDING_PRODUCT_MINOR_VERSION=$(cat ${TOPLEVEL_VERSIONS} | grep -F "PRODUCT_MINOR_VERSION := " | sed -e 's/PRODUCT_MINOR_VERSION := //g')
BRANDING_SEARCH=xensearch
BRANDING_UPDATE=xsupdate
BRANDING_BACKUP=xbk
BRANDING_SERVER=${BRANDING_PRODUCT_BRAND}
BRANDING_BRAND_CONSOLE=$(cat ${TOPLEVEL_BRANDING} | grep -F "BRAND_CONSOLE := " | sed -e 's/BRAND_CONSOLE := //g')

# Check for the micro version override from declarations.sh and use it if present otherwise use the one from branding
if [ -n "${PRODUCT_MICRO_VERSION_OVERRIDE+x}" ]; then
  BRANDING_PRODUCT_MICRO_VERSION=${PRODUCT_MICRO_VERSION_OVERRIDE}
  echo Using override for micro product number of: ${BRANDING_PRODUCT_MICRO_VERSION}
else
  BRANDING_PRODUCT_MICRO_VERSION=$(cat ${TOPLEVEL_VERSIONS} | grep -F "PRODUCT_MICRO_VERSION := " | sed -e 's/PRODUCT_MICRO_VERSION := //g')
fi

BRANDING_PRODUCT_VERSION=${BRANDING_PRODUCT_MAJOR_VERSION}.${BRANDING_PRODUCT_MINOR_VERSION}.${BRANDING_PRODUCT_MICRO_VERSION}

BRANDING_XC_PRODUCT_VERSION=${BRANDING_PRODUCT_VERSION}
BRANDING_XC_PRODUCT_5_6_VERSION=5.6
BRANDING_XC_PRODUCT_6_0_VERSION=6.0
BRANDING_XC_PRODUCT_6_2_VERSION=6.2
BRANDING_XC_PRODUCT_6_5_VERSION=6.5
BRANDING_XC_PRODUCT_7_0_VERSION=7.0
BRANDING_XENSERVER_UPDATE_URL="http://updates.xensource.com/XenServer/updates.xml"
BRANDING_HIDDEN_FEATURES=""
BRANDING_ADDITIONAL_FEATURES=""

#GUID
BRANDING_VNC_CONTROL_UPGRADE_CODE_GUID=A77AF69F-14AF-4cd0-B978-236945C7AC97
BRANDING_VNC_MAIN_CONTROL_GUID=C2E335C1-3ADF-492d-BD03-27DA10A44232
BRANDING_XENCENTER_UPGRADE_CODE_GUID=EA0EF50F-5CC6-452B-B09F-3F5EC564899D
BRANDING_JA_RESOURCES_GUID=D3ADD803-AF0B-4787-AC29-C6387FFF403B
BRANDING_SC_RESOURCES_GUID=381e9319-f0c4-4c69-a1c2-0a2fc725bd19
BRANDING_REPORT_VIEWER_GUID=D01090B9-1988-4ab4-B48A-D0B6161FAA48
BRANDING_MAIN_EXECUTABLE_GUID=64FEF765-7593-4612-8D4D-EE81CF704DEB
BRANDING_TEST_RESOURCES_GUID=FA8D4F56-A94A-467c-9E6B-F3DC26F95B1E
BRANDING_EXTERNAL_TOOLS_GUID=D5FC0252-C97B-46e7-9633-A6B68EDB6654
BRANDING_SCHEMAS_FILES_GUID=E2186CD8-5064-4414-8AD7-E4495B6A3204
BRANDING_REGISTRY_ENTRIES_GUID=193BAE1F-F2AE-4451-94DC-4B105DB5179C
BRANDING_APPLICAION_SHOTCUT_GUID=6B875059-26BC-4fa7-ACB7-0B9A4E4665CA
BRANDING_README_FILE_GUID=47427a60-4064-4fdb-878d-04309a0fd9ce
BRANDING_XSUPDATE_FILE_GUID=1cfbf607-cc80-4bf8-b2fc-37e69c872316
BRANDING_HEALTH_CHECK_GUID=9D686BFC-B4FD-435F-AC74-0ACE29425095
