################################################################################
# Automatically-generated file. Do not edit!
################################################################################

-include ../makefile.init

RM := rm -rf

# All of the sources participating in the build are defined here
-include sources.mk
-include src/subdir.mk
-include subdir.mk
-include objects.mk
ifneq ($(MAKECMDGOALS),clean)
ifneq ($(strip $(C++_DEPS)),)
-include $(C++_DEPS)
endif
ifneq ($(strip $(C_DEPS)),)
-include $(C_DEPS)
endif
ifneq ($(strip $(CC_DEPS)),)
-include $(CC_DEPS)
endif
ifneq ($(strip $(CPP_DEPS)),)
-include $(CPP_DEPS)
endif
ifneq ($(strip $(CXX_DEPS)),)
-include $(CXX_DEPS)
endif
ifneq ($(strip $(C_UPPER_DEPS)),)
-include $(C_UPPER_DEPS)
endif
endif

-include ../makefile.defs

# Add inputs and outputs from these tool invocations to the build variables 

# All Target
all: MyHondana.exe secondary-outputs
# Tool invocations
MyHondana.exe: $(OBJS) $(USER_OBJS)
	@echo 'Building target: $@'
	@echo 'Invoking: C++ Linker'
	-$(RM) .OBJ_LIST
	i386-linux-gnueabi-ld.exe -r -o xxxlib20.o  src/AnimationBaseForm.o src/AnimationPropertyInfo.o src/AppResourceId.o src/BookmarkListPanel.o src/ContentsListPanel.o src/CoverFlowPanel.o src/DeleteCheckPopupPanel.o src/DeletePopupPanel.o src/HttpCommonResource.o src/HttpCommunicationService.o src/MyHondana.o src/MyHondanaDeleteForm.o src/MyHondanaDetailForm.o src/MyHondanaEntry.o src/MyHondanaFormFactory.o src/MyHondanaFrame.o src/MyHondanaHelpForm.o src/MyHondanaLoginForm.o src/MyHondanaMainForm.o src/MyHondanaMarketForm.o
	i386-linux-gnueabi-ld.exe -r -o xxxlib26.o  src/MyHondanaPanelFactory.o src/MyHondanaSettingForm.o src/MyHondanaViewerForm.o src/MyHondanaViewerMoveForm.o src/SceneRegister.o src/SortPopupPanel.o
	clang++.exe -o"MyHondana.exe"  xxxlib20.o xxxlib26.o $(USER_OBJS) $(LIBS) -target i386-tizen-linux-gnueabi -gcc-toolchain "C:/tizen-sdk/tools/smart-build-interface/../i386-linux-gnueabi-gcc-4.5/" -ccc-gcc-name i386-linux-gnueabi-g++ -march=i386 -Xlinker --as-needed -pie -lpthread -Xlinker -rpath="/opt/usr/apps/docomo7003/lib" -Xlinker -rpath="/home/developer/sdk_tools/lib" --sysroot="C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-emulator-2.2.native" -L"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-emulator-2.2.native/usr/lib" -L"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-emulator-2.2.native/usr/lib/osp" -losp-uifw -losp-appfw -losp-image -losp-json -losp-ime -losp-net -lpthread -losp-content -losp-locations -losp-telephony -losp-uix -losp-media -losp-messaging -losp-web -losp-social -losp-wifi -losp-bluetooth -losp-nfc -losp-face -losp-speech-tts -losp-speech-stt -losp-shell -losp-shell-core -losp-vision -lxml2 -lalut -lopenal
	@echo 'Finished building target: $@'
	@echo ' '
# Other Targets
clean:
	@FOR %%i IN ( $(OBJS) ) DO ( $(RM) "%%i" )
	-$(RM) $(MO_FILES)$(C++_DEPS)$(C_DEPS)$(CC_DEPS)$(EDJ_FILES)$(CPP_DEPS)$(EXECUTABLES)$(CXX_DEPS)$(C_UPPER_DEPS) MyHondana.exe
	-@echo ' '
secondary-outputs: $(MO_FILES) $(EDJ_FILES)
.PHONY: all clean dependents
.SECONDARY:
-include ../makefile.targets
