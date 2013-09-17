S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMG3
Build-Date: 2013.07.16 04:12:03

Crash Information
Process Name: MyHondana
PID: 29596
Date: 2013-07-24 22:36:28(GMT+0900)
Executable File Path: /opt/apps/docomo6003/bin/MyHondana
This process is multi-thread process
pid=29596 tid=29596
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 29596, uid 5000)

Register Information
r0   = 0x0071d598, r1   = 0x0071f064
r2   = 0x00000001, r3   = 0xb41fec34
r4   = 0xb4208f70, r5   = 0x0071d598
r6   = 0x00b986a0, r7   = 0x0064f108
r8   = 0xbeae44f0, r9   = 0x006d65e8
r10  = 0xb47429d0, fp   = 0xbeae4408
ip   = 0xb420aed8, sp   = 0xbeae4398
lr   = 0xb3b7f27d, pc   = 0xb41fec34
cpsr = 0x880f0010

Memory Information
MemTotal:  2063908 KB
MemFree:    323960 KB
Buffers:     62544 KB
Cached:    1049048 KB
VmPeak:     236856 KB
VmSize:     177580 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:      115672 KB
VmRSS:      115672 KB
VmData:      73780 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       66924 KB
VmPTE:         212 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00072000 rw-p [heap]
00072000 01075000 rw-p [heap]
af913000 af915000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
af96e000 b016d000 rwxp [stack:29611]
b018a000 b019b000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b01a4000 b01a9000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b0574000 b0578000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b0581000 b0d80000 rwxp [stack:29598]
b0d80000 b0d86000 r-xp /usr/lib/libUMP.so
b0d8e000 b0edc000 r-xp /usr/lib/r3p2/libMali.so
b0ee8000 b0f11000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b0f1c000 b0f3a000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b1275000 b12c1000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b12ca000 b12cf000 r-xp /usr/lib/libjson.so.0.0.1
b12d7000 b12db000 r-xp /usr/lib/liblocation-pos-log.so
b12e3000 b12f5000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b12fd000 b12ff000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b1307000 b130c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b1314000 b131f000 r-xp /usr/lib/libdrm-trusted.so.0.0.53
b1327000 b1329000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b1331000 b133e000 r-xp /usr/lib/libdrm-client.so.0.0.91
b1347000 b134f000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b1371000 b13a8000 r-xp /usr/lib/libpulse.so.0.16.2
b13b0000 b1414000 r-xp /usr/lib/libasound.so.2.0.0
b141e000 b1421000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b142a000 b142e000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b1437000 b1454000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b145c000 b1461000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b1469000 b1496000 r-xp /usr/lib/libSLP-location.so.0.0.0
b149f000 b14a8000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b14b1000 b14b5000 r-xp /usr/lib/libmmffile.so.0.0.0
b14bd000 b14c5000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b14cd000 b14e7000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b14ef000 b150a000 r-xp /usr/lib/libmedia-service.so.1.0.0
b1512000 b151d000 r-xp /usr/lib/libmdm-common.so.1.0.38
b1525000 b1533000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.7
b153c000 b1543000 r-xp /usr/lib/libenchant.so.1.6.1
b154b000 b154e000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.9
b1557000 b1560000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b1569000 b156d000 r-xp /usr/lib/libmmfsession.so.0.0.0
b1576000 b1585000 r-xp /usr/lib/libmmfsound.so.0.1.0
b158d000 b1592000 r-xp /usr/lib/libmemenv.so.1.1.0
b159a000 b15d8000 r-xp /usr/lib/libleveldb.so.1.1.0
b15e1000 b160b000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b1614000 b1616000 r-xp /usr/lib/libsecfw.so
b161e000 b1627000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b1632000 b1641000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1649000 b1661000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b1663000 b1670000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b1679000 b1682000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b168a000 b16cc000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b16d5000 b1771000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b177d000 b17a2000 r-xp /usr/lib/libxslt.so.1.1.16
b17ab000 b17ad000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b17b5000 b17bd000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b17c5000 b17d1000 r-xp /usr/lib/libcapi-location-manager.so.0.1.14
b17d9000 b17dc000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b17e4000 b17e9000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b17f1000 b1818000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.71
b1820000 b1836000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b183f000 b187d000 r-xp /usr/lib/libmdm.so.1.0.66
b1885000 b189a000 r-xp /usr/lib/libnetwork.so.0.0.0
b18a2000 b18ab000 r-xp /usr/lib/libcapi-web-favorites.so
b18b3000 b2b11000 r-xp /usr/lib/libewebkit2.so.0.10.150.3
b2c04000 b2c57000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2c60000 b2c77000 r-xp /usr/lib/libwifi-direct.so.0.0
b2c7f000 b2c87000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.10
b2c8f000 b2c98000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b2ca1000 b2cac000 r-xp /usr/lib/libcapi-network-connection.so.0.1.13
b2cb4000 b2d20000 r-xp /usr/lib/osp/libosp-web.so.1.2.2.0
b2d2d000 b2de2000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2def000 b2e09000 r-xp /usr/lib/osp/libosp-json.so.1.2.2.0
b2e12000 b2e30000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2e3f000 b2e49000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b2e51000 b2ec0000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana.exe
b2ecc000 b2f48000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2f50000 b2fe0000 r-xp /usr/lib/libCOREGL.so.3.0
b2fea000 b2fed000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2ff5000 b2ffc000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3005000 b3014000 r-xp /usr/lib/libICE.so.6.3.0
b301e000 b3023000 r-xp /usr/lib/libSM.so.6.0.1
b302b000 b302c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3034000 b3036000 r-xp /usr/lib/libledplayer.so.0.1
b303e000 b3044000 r-xp /usr/lib/libxcb-render.so.0.0.0
b304c000 b304d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3056000 b305d000 r-xp /usr/lib/libGLESv2.so.2.0
b3065000 b30ac000 r-xp /usr/lib/libtiff.so.5.1.0
b30b7000 b30e0000 r-xp /usr/lib/libturbojpeg.so
b30f9000 b30fd000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3106000 b310c000 r-xp /usr/lib/libgif.so.4.1.6
b3114000 b3136000 r-xp /usr/lib/libavutil.so.51.73.101
b3145000 b3173000 r-xp /usr/lib/libswscale.so.2.1.101
b317c000 b3473000 r-xp /usr/lib/libavcodec.so.54.59.100
b379a000 b37b3000 r-xp /usr/lib/libpng12.so.0.50.0
b37bc000 b37c3000 r-xp /usr/lib/libfeedback.so.0.1.4
b37cc000 b37e0000 r-xp /usr/lib/libtts.so
b37e8000 b37ea000 r-xp /usr/lib/libEGL.so.1.4
b37f2000 b38a9000 r-xp /usr/lib/libcairo.so.2.11200.12
b38b3000 b38cc000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b38d6000 b38da000 r-xp /usr/lib/libss-client.so.1.0.0
b38e3000 b38e5000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana
b38ed000 b41a3000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b4213000 b421c000 r-xp /usr/lib/libslp_devman_plugin.so
b4225000 b4227000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b422f000 b4232000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b423a000 b423d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4245000 b4252000 r-xp /usr/lib/libmodem.so.0.0.0
b425a000 b425d000 r-xp /usr/lib/libdevice-node.so.0.1
b4265000 b4275000 r-xp /usr/lib/libaccounts-svc.so.0.2.71
b427d000 b4280000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b4288000 b428c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4294000 b429a000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b42a2000 b42a3000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b42ac000 b42af000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b42b7000 b42ba000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b42c3000 b42c6000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b42ce000 b42cf000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b42d7000 b42e5000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b42ee000 b42f4000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b42fc000 b4321000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b4329000 b432c000 r-xp /usr/lib/libuuid.so.1.3.0
b4335000 b4349000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4352000 b435a000 r-xp /usr/lib/libminizip.so.1.0.0
b4362000 b436e000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b4377000 b4395000 r-xp /usr/lib/libpcre.so.0.0.1
b439d000 b43a1000 r-xp /usr/lib/libheynoti.so.0.0.2
b43a9000 b43b7000 r-xp /usr/lib/libdeviced.so.0.1.0
b43bf000 b43ca000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b43d7000 b43dd000 r-xp /usr/lib/libdevman.so.0.1
b43e5000 b43e9000 r-xp /usr/lib/libchromium.so.1.0
b43f1000 b43f8000 r-xp /usr/lib/libalarm.so.0.0.0
b4400000 b440a000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b4413000 b4725000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b474d000 b4757000 r-xp /lib/libnss_files-2.13.so
b4767000 b4777000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.4
b4778000 b478c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b4794000 b47b1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b47b9000 b47bc000 r-xp /usr/lib/libiniparser.so.0
b47c5000 b4818000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b4822000 b4836000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b483f000 b4850000 r-xp /usr/lib/libcom-core.so.0.0.1
b4858000 b485e000 r-xp /usr/lib/libappsvc.so.0.1.0
b4866000 b4868000 r-xp /usr/lib/libdri2.so.0.0.0
b4870000 b4878000 r-xp /usr/lib/libdrm.so.2.4.0
b4880000 b4884000 r-xp /usr/lib/libtbm.so.1.0.0
b488c000 b488f000 r-xp /usr/lib/libXv.so.1.0.0
b4897000 b48a9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b48b2000 b497e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4994000 b49a3000 r-xp /usr/lib/libnotification.so.0.1.0
b49ab000 b49cf000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b49d8000 b49e8000 r-xp /lib/libresolv-2.13.so
b49ec000 b49ee000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b49f6000 b4ace000 r-xp /usr/lib/libxml2.so.2.7.8
b4adb000 b4bb8000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4bc3000 b4bc8000 r-xp /usr/lib/libcheck.so.0.0.0
b4bd0000 b4bda000 r-xp /usr/lib/libspdy.so.0.0.0
b4be3000 b4d36000 r-xp /usr/lib/libcrypto.so.1.0.0
b4d54000 b4da0000 r-xp /usr/lib/libssl.so.1.0.0
b4dac000 b4dda000 r-xp /usr/lib/libidn.so.11.5.44
b4de3000 b4ded000 r-xp /usr/lib/libcares.so.2.1.0
b4df5000 b4e0c000 r-xp /lib/libexpat.so.1.5.2
b4e16000 b4e3a000 r-xp /usr/lib/libicule.so.48.1
b4e43000 b4e51000 r-xp /usr/lib/libsf_common.so
b4e5a000 b4ef5000 r-xp /usr/lib/libstdc++.so.6.0.14
b4f08000 b4f20000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4f21000 b4f24000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4f2c000 b4f30000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4f39000 b4f3e000 r-xp /usr/lib/libffi.so.5.0.10
b4f46000 b4f47000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4f4f000 b4f59000 r-xp /usr/lib/libXext.so.6.4.0
b4f62000 b4f65000 r-xp /usr/lib/libXtst.so.6.1.0
b4f6d000 b4f73000 r-xp /usr/lib/libXrender.so.1.3.0
b4f7b000 b4f81000 r-xp /usr/lib/libXrandr.so.2.2.0
b4f89000 b4f8a000 r-xp /usr/lib/libXinerama.so.1.0.0
b4f93000 b4f9c000 r-xp /usr/lib/libXi.so.6.1.0
b4fa4000 b4fa7000 r-xp /usr/lib/libXfixes.so.3.1.0
b4faf000 b4fb1000 r-xp /usr/lib/libXgesture.so.7.0.0
b4fb9000 b4fba000 r-xp /usr/lib/libXdamage.so.1.1.0
b4fc3000 b4fca000 r-xp /usr/lib/libXcursor.so.1.0.2
b4fd2000 b4ff5000 r-xp /usr/lib/libexif.so.12.3.3
b5009000 b5013000 r-xp /usr/lib/libethumb.so.1.7.99
b501b000 b505f000 r-xp /usr/lib/libsndfile.so.1.0.25
b506d000 b506f000 r-xp /usr/lib/libctxdata.so.0.0.0
b5077000 b5085000 r-xp /usr/lib/libremix.so.0.0.0
b508d000 b508e000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5096000 b50af000 r-xp /usr/lib/liblua-5.1.so
b50b8000 b50bf000 r-xp /usr/lib/libembryo.so.1.7.99
b50c8000 b5108000 r-xp /usr/lib/libcurl.so.4.3.0
b5111000 b517b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5188000 b51ac000 r-xp /usr/lib/libfontconfig.so.1.5.0
b51b5000 b5211000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5223000 b5237000 r-xp /usr/lib/libfribidi.so.0.3.1
b523f000 b5297000 r-xp /usr/lib/libfreetype.so.6.8.1
b52a2000 b52c6000 r-xp /usr/lib/libjpeg.so.8.0.2
b52de000 b52f5000 r-xp /lib/libz.so.1.2.5
b52fd000 b5305000 r-xp /usr/lib/libemotion.so.1.7.99
b530d000 b5312000 r-xp /usr/lib/libecore_fb.so.1.7.99
b531b000 b5329000 r-xp /usr/lib/libsensor.so.1.1.0
b5335000 b533b000 r-xp /usr/lib/libappcore-common.so.1.1
b5343000 b5345000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.80
b534d000 b5358000 r-xp /usr/lib/libresourced.so.0.2.80
b5360000 b5363000 r-xp /usr/lib/libproc-stat.so.0.2.80
b6360000 b6448000 r-xp /usr/lib/libicuuc.so.48.1
b6455000 b6575000 r-xp /usr/lib/libicui18n.so.48.1
b6583000 b6586000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b658e000 b6596000 r-xp /usr/lib/libvconf.so.0.2.45
b659e000 b65a4000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65ac000 b65b8000 r-xp /usr/lib/libail.so.0.1.0
b65c0000 b65cb000 r-xp /usr/lib/libaul.so.0.1.0
b65d4000 b65eb000 r-xp /usr/lib/libecore_input.so.1.7.99
b6606000 b6623000 r-xp /usr/lib/libecore_evas.so.1.7.99
b662c000 b662e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6636000 b666a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6673000 b66a2000 r-xp /usr/lib/libecore_x.so.1.7.99
b66ac000 b66eb000 r-xp /usr/lib/libeina.so.1.7.99
b66f4000 b6709000 r-xp /usr/lib/libecore.so.1.7.99
b6720000 b673b000 r-xp /usr/lib/libecore_con.so.1.7.99
b6744000 b6749000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6751000 b6759000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6761000 b676a000 r-xp /usr/lib/libedbus.so.1.7.99
b6772000 b6774000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b677c000 b6780000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6789000 b679f000 r-xp /usr/lib/libefreet.so.1.7.99
b67a9000 b6805000 r-xp /usr/lib/libedje.so.1.7.99
b680f000 b68bf000 r-xp /usr/lib/libevas.so.1.7.99
b68d9000 b68ec000 r-xp /usr/lib/libeet.so.1.7.99
b68f5000 b695f000 r-xp /lib/libm-2.13.so
b6968000 b6969000 r-xp /usr/lib/libpmapi.so.1.2
b6971000 b6978000 r-xp /usr/lib/libutilX.so.1.1.0
b6980000 b6aa2000 r-xp /usr/lib/libelementary.so.1.7.99
b6ab7000 b6aba000 r-xp /lib/libattr.so.1.1.0
b6ac2000 b6ac4000 r-xp /usr/lib/libXau.so.6.0.0
b6acc000 b6ad2000 r-xp /lib/librt-2.13.so
b6adb000 b6ae3000 r-xp /lib/libcrypt-2.13.so
b6b13000 b6b16000 r-xp /lib/libcap.so.2.21
b6b1e000 b6b20000 r-xp /usr/lib/libiri.so
b6b28000 b6b3d000 r-xp /usr/lib/libxcb.so.1.1.0
b6b45000 b6b50000 r-xp /lib/libunwind.so.8.0.1
b6b7e000 b6c9b000 r-xp /lib/libc-2.13.so
b6ca9000 b6cb2000 r-xp /lib/libgcc_s-4.5.3.so.1
b6cba000 b6ce6000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6cef000 b6cf2000 r-xp /usr/lib/libbundle.so.0.1.22
b6cfa000 b6cfc000 r-xp /lib/libdl-2.13.so
b6d05000 b6d08000 r-xp /usr/lib/libsmack.so.1.0.0
b6d10000 b6dea000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6df3000 b6e07000 r-xp /lib/libpthread-2.13.so
b6e13000 b6e18000 r-xp /usr/lib/libecore_file.so.1.7.99
b6e20000 b6e28000 r-xp /usr/lib/libappcore-efl.so.1.1
b6e2a000 b6e2b000 r-xp /usr/lib/libdlog.so.0.0.0
b6e34000 b6ea1000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6eab000 b6eb5000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ebd000 b6fa3000 r-xp /usr/lib/libX11.so.6.3.0
b6fae000 b6faf000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6fb7000 b6fbb000 r-xp /usr/lib/libsys-assert.so
b6fc3000 b6fe0000 r-xp /lib/ld-2.13.so
beac5000 beae6000 rwxp [stack]
b6fc3000 b6fe0000 r-xp /lib/ld-2.13.so
beac5000 beae6000 rwxp [stack]
End of Maps Information

Callstack Information (PID:29596)
Call Stack Count: 1
 0: (0xb41fec34) [/usr/lib/osp/libosp-uifw.so] + 0xb41fec34
End of Call Stack

Package Information
Package Name: docomo6003.MyHondana
Package ID : docomo6003
Version: 1.0.0
Package Type: tpk
App Name: d book MyShelf
App ID: docomo6003.MyHondana
Type: Application
Categories: (NULL)
