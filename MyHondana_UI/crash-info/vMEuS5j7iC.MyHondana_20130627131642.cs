S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMF4
Build-Date: 2013.06.25 21:23:12

Crash Information
Process Name: MyHondana
PID: 5761
Date: 2013-06-27 13:16:42(GMT+0900)
Executable File Path: /opt/apps/vMEuS5j7iC/bin/MyHondana
This process is multi-thread process
pid=5761 tid=5761
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5761, uid 5000)
      TIMER: -2

Register Information
r0   = 0x00000000, r1   = 0x001b4898
r2   = 0x042f7600, r3   = 0xb3d074f1
r4   = 0x001b4870, r5   = 0x001b4898
r6   = 0x001b4898, r7   = 0x00000000
r8   = 0x001b8ea0, r9   = 0xbecfeac4
r10  = 0x00000001, fp   = 0xbecfe8d8
ip   = 0xb41a1ce4, sp   = 0xbecfe0b0
lr   = 0xb3b27dab, pc   = 0xb3b419b4
cpsr = 0x680f0030

Memory Information
MemTotal:  2063912 KB
MemFree:   1165140 KB
Buffers:     30716 KB
Cached:     539032 KB
VmPeak:     121152 KB
VmSize:     117032 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26604 KB
VmRSS:       26604 KB
VmData:      16720 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       65980 KB
VmPTE:          98 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00070000 rw-p [heap]
00070000 00217000 rw-p [heap]
b05be000 b05c2000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b05cb000 b0dca000 rwxp [stack:5763]
b0dca000 b0f18000 r-xp /usr/lib/r3p2/libMali.so
b0f24000 b0f4c000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b0f50000 b0f6e000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b0f80000 b0f86000 r-xp /usr/lib/libUMP.so
b12c7000 b1313000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b131c000 b1321000 r-xp /usr/lib/libjson.so.0.0.1
b1329000 b132d000 r-xp /usr/lib/liblocation-pos-log.so
b1335000 b1340000 r-xp /usr/lib/libmdm-common.so.1.0.37
b1348000 b135a000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b1362000 b1364000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b136c000 b1371000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b1379000 b1384000 r-xp /usr/lib/libdrm-trusted.so.0.0.51
b138c000 b138e000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b1396000 b13a3000 r-xp /usr/lib/libdrm-client.so.0.0.90
b13ac000 b13b4000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b13d6000 b140d000 r-xp /usr/lib/libpulse.so.0.16.2
b1415000 b1479000 r-xp /usr/lib/libasound.so.2.0.0
b1483000 b1486000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b148f000 b1493000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b149c000 b14b9000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b14c1000 b14c5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b14cd000 b14fa000 r-xp /usr/lib/libSLP-location.so.0.0.0
b1503000 b1540000 r-xp /usr/lib/libmdm.so.1.0.63
b1548000 b154c000 r-xp /usr/lib/libss-client.so.1.0.0
b1555000 b155e000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b1566000 b156a000 r-xp /usr/lib/libmmffile.so.0.0.0
b1572000 b1579000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b1581000 b159b000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b15a3000 b15be000 r-xp /usr/lib/libmedia-service.so.1.0.0
b15c6000 b15db000 r-xp /usr/lib/libnetwork.so.0.0.0
b15e3000 b15f1000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.6
b15fa000 b1601000 r-xp /usr/lib/libenchant.so.1.6.1
b1609000 b160c000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.8
b1615000 b161e000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b1627000 b162b000 r-xp /usr/lib/libmmfsession.so.0.0.0
b1634000 b1642000 r-xp /usr/lib/libmmfsound.so.0.1.0
b164a000 b164f000 r-xp /usr/lib/libmemenv.so.1.1.0
b1657000 b1695000 r-xp /usr/lib/libleveldb.so.1.1.0
b169e000 b16c8000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b16d1000 b16d3000 r-xp /usr/lib/libsecfw.so
b16db000 b16e4000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b16ef000 b16fe000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1706000 b171e000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b1720000 b172d000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b1736000 b173f000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b1747000 b1789000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b1792000 b182e000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b183a000 b185f000 r-xp /usr/lib/libxslt.so.1.1.16
b1868000 b186a000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b1872000 b187a000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b1882000 b188d000 r-xp /usr/lib/libcapi-location-manager.so.0.1.12
b1895000 b18b0000 r-xp /usr/lib/libwifi-direct.so.0.0
b18b8000 b18c0000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.6
b18c8000 b18d1000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b18d9000 b18dc000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b18e4000 b190b000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.70
b1913000 b1929000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b1932000 b193c000 r-xp /usr/lib/libcapi-network-connection.so.0.1.10
b1944000 b194d000 r-xp /usr/lib/libcapi-web-favorites.so
b1955000 b2ba5000 r-xp /usr/lib/libewebkit2.so.0.10.141.3
b2c97000 b2d4c000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2d59000 b2d77000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2d80000 b2d9a000 r-xp /usr/lib/osp/libosp-json.so.1.2.1.0
b2da3000 b2df6000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2dff000 b2e63000 r-xp /usr/lib/osp/libosp-web.so.1.2.1.0
b2e76000 b2e80000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b2e88000 b2ea3000 r-xp /opt/usr/apps/vMEuS5j7iC/bin/MyHondana.exe
b2eac000 b2ef4000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2efc000 b2f8c000 r-xp /usr/lib/libCOREGL.so.3.0
b2f96000 b2f99000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2fa1000 b2fa8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2fb1000 b2fc0000 r-xp /usr/lib/libICE.so.6.3.0
b2fca000 b2fcf000 r-xp /usr/lib/libSM.so.6.0.1
b2fd7000 b2fd8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2fe0000 b2fe2000 r-xp /usr/lib/libledplayer.so.0.1
b2fea000 b2ff0000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2ff8000 b2ff9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3002000 b3009000 r-xp /usr/lib/libGLESv2.so.2.0
b3011000 b3058000 r-xp /usr/lib/libtiff.so.5.1.0
b3063000 b308c000 r-xp /usr/lib/libturbojpeg.so
b30a5000 b30a9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b30b2000 b30b8000 r-xp /usr/lib/libgif.so.4.1.6
b30c0000 b30e2000 r-xp /usr/lib/libavutil.so.51.73.101
b30f1000 b311f000 r-xp /usr/lib/libswscale.so.2.1.101
b3128000 b341f000 r-xp /usr/lib/libavcodec.so.54.59.100
b3746000 b375f000 r-xp /usr/lib/libpng12.so.0.50.0
b3768000 b376f000 r-xp /usr/lib/libfeedback.so.0.1.4
b3778000 b378b000 r-xp /usr/lib/libtts.so
b3793000 b3795000 r-xp /usr/lib/libEGL.so.1.4
b379d000 b3854000 r-xp /usr/lib/libcairo.so.2.11200.12
b385e000 b3877000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b3881000 b3886000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b388e000 b3890000 r-xp /opt/usr/apps/vMEuS5j7iC/bin/MyHondana
b3898000 b413a000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b41aa000 b41b3000 r-xp /usr/lib/libslp_devman_plugin.so
b41bc000 b41be000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b41c6000 b41c9000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b41d1000 b41d4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b41dc000 b41e9000 r-xp /usr/lib/libmodem.so.0.0.0
b41f1000 b41f4000 r-xp /usr/lib/libdevice-node.so.0.1
b41fc000 b420c000 r-xp /usr/lib/libaccounts-svc.so.0.2.68
b4214000 b4217000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b421f000 b422a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4232000 b4239000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4242000 b4247000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b424f000 b4250000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b4259000 b425c000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b4264000 b4269000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b4271000 b4274000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b427c000 b427d000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b4285000 b4293000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b429c000 b42a2000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b42aa000 b42cf000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b42d7000 b42da000 r-xp /usr/lib/libuuid.so.1.3.0
b42e3000 b42f7000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b42ff000 b4300000 r-xp /usr/lib/libpmapi.so.1.2
b4308000 b4310000 r-xp /usr/lib/libminizip.so.1.0.0
b4318000 b4324000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b432d000 b434b000 r-xp /usr/lib/libpcre.so.0.0.1
b4353000 b4357000 r-xp /usr/lib/libheynoti.so.0.0.2
b435f000 b436d000 r-xp /usr/lib/libdeviced.so.0.1.0
b4376000 b4381000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b438e000 b4397000 r-xp /usr/lib/libdevman.so.0.1
b439f000 b43a3000 r-xp /usr/lib/libchromium.so.1.0
b43ab000 b43b2000 r-xp /usr/lib/libalarm.so.0.0.0
b43ba000 b46c7000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b46ef000 b46f9000 r-xp /lib/libnss_files-2.13.so
b4709000 b4719000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.3
b471a000 b472d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b4735000 b4752000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b475a000 b475d000 r-xp /usr/lib/libiniparser.so.0
b4766000 b47b6000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b47c0000 b47d4000 r-xp /usr/lib/libcom-core.so.0.0.1
b47dc000 b47e2000 r-xp /usr/lib/libappsvc.so.0.1.0
b47ea000 b47ec000 r-xp /usr/lib/libdri2.so.0.0.0
b47f4000 b47fc000 r-xp /usr/lib/libdrm.so.2.4.0
b4804000 b4808000 r-xp /usr/lib/libtbm.so.1.0.0
b4810000 b4813000 r-xp /usr/lib/libXv.so.1.0.0
b481b000 b48e7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b48fd000 b490c000 r-xp /usr/lib/libnotification.so.0.1.0
b4914000 b4938000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4941000 b4951000 r-xp /lib/libresolv-2.13.so
b4955000 b4957000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b495f000 b4a37000 r-xp /usr/lib/libxml2.so.2.7.8
b4a44000 b4b21000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4b2c000 b4b31000 r-xp /usr/lib/libcheck.so.0.0.0
b4b39000 b4b43000 r-xp /usr/lib/libspdy.so.0.0.0
b4b4c000 b4c9f000 r-xp /usr/lib/libcrypto.so.1.0.0
b4cbd000 b4d09000 r-xp /usr/lib/libssl.so.1.0.0
b4d15000 b4d43000 r-xp /usr/lib/libidn.so.11.5.44
b4d4c000 b4d56000 r-xp /usr/lib/libcares.so.2.1.0
b4d5e000 b4d75000 r-xp /lib/libexpat.so.1.5.2
b4d7f000 b4da3000 r-xp /usr/lib/libicule.so.48.1
b4dac000 b4dba000 r-xp /usr/lib/libsf_common.so
b4dc3000 b4e5e000 r-xp /usr/lib/libstdc++.so.6.0.14
b4e71000 b4e89000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4e8a000 b4e8d000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4e95000 b4e99000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4ea2000 b4ea7000 r-xp /usr/lib/libffi.so.5.0.10
b4eaf000 b4eb0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4eb8000 b4ec2000 r-xp /usr/lib/libXext.so.6.4.0
b4ecb000 b4ece000 r-xp /usr/lib/libXtst.so.6.1.0
b4ed6000 b4edc000 r-xp /usr/lib/libXrender.so.1.3.0
b4ee4000 b4eea000 r-xp /usr/lib/libXrandr.so.2.2.0
b4ef2000 b4ef3000 r-xp /usr/lib/libXinerama.so.1.0.0
b4efc000 b4f05000 r-xp /usr/lib/libXi.so.6.1.0
b4f0d000 b4f10000 r-xp /usr/lib/libXfixes.so.3.1.0
b4f18000 b4f1a000 r-xp /usr/lib/libXgesture.so.7.0.0
b4f22000 b4f23000 r-xp /usr/lib/libXdamage.so.1.1.0
b4f2c000 b4f33000 r-xp /usr/lib/libXcursor.so.1.0.2
b4f3b000 b4f5e000 r-xp /usr/lib/libexif.so.12.3.3
b4f72000 b4f7c000 r-xp /usr/lib/libethumb.so.1.7.99
b4f84000 b4fc8000 r-xp /usr/lib/libsndfile.so.1.0.25
b4fd6000 b4fd8000 r-xp /usr/lib/libctxdata.so.0.0.0
b4fe0000 b4fee000 r-xp /usr/lib/libremix.so.0.0.0
b4ff6000 b4ff7000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4fff000 b5018000 r-xp /usr/lib/liblua-5.1.so
b5021000 b5028000 r-xp /usr/lib/libembryo.so.1.7.99
b5031000 b5071000 r-xp /usr/lib/libcurl.so.4.3.0
b507a000 b50e4000 r-xp /usr/lib/libpixman-1.so.0.28.2
b50f1000 b5115000 r-xp /usr/lib/libfontconfig.so.1.5.0
b511e000 b517a000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b518c000 b51a0000 r-xp /usr/lib/libfribidi.so.0.3.1
b51a8000 b5200000 r-xp /usr/lib/libfreetype.so.6.8.1
b520b000 b522f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5247000 b525e000 r-xp /lib/libz.so.1.2.5
b5266000 b526e000 r-xp /usr/lib/libemotion.so.1.7.99
b5276000 b527b000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5284000 b5292000 r-xp /usr/lib/libsensor.so.1.1.0
b529e000 b52a4000 r-xp /usr/lib/libappcore-common.so.1.1
b52ac000 b52ae000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.78
b52b6000 b52bf000 r-xp /usr/lib/libresourced.so.0.2.78
b52c8000 b52cb000 r-xp /usr/lib/libproc-stat.so.0.2.78
b62c8000 b63b0000 r-xp /usr/lib/libicuuc.so.48.1
b63bd000 b64dd000 r-xp /usr/lib/libicui18n.so.48.1
b64eb000 b64ee000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b64f6000 b64ff000 r-xp /usr/lib/libvconf.so.0.2.45
b6507000 b650d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6515000 b6521000 r-xp /usr/lib/libail.so.0.1.0
b6529000 b6534000 r-xp /usr/lib/libaul.so.0.1.0
b653c000 b6553000 r-xp /usr/lib/libecore_input.so.1.7.99
b656e000 b658b000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6594000 b6596000 r-xp /usr/lib/libXcomposite.so.1.0.0
b659e000 b65d2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b65db000 b660a000 r-xp /usr/lib/libecore_x.so.1.7.99
b6614000 b6653000 r-xp /usr/lib/libeina.so.1.7.99
b665c000 b6671000 r-xp /usr/lib/libecore.so.1.7.99
b6688000 b66a3000 r-xp /usr/lib/libecore_con.so.1.7.99
b66ac000 b66b1000 r-xp /usr/lib/libecore_imf.so.1.7.99
b66b9000 b66c1000 r-xp /usr/lib/libethumb_client.so.1.7.99
b66c9000 b66d2000 r-xp /usr/lib/libedbus.so.1.7.99
b66da000 b66dc000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b66e4000 b66e8000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b66f1000 b6707000 r-xp /usr/lib/libefreet.so.1.7.99
b6711000 b676d000 r-xp /usr/lib/libedje.so.1.7.99
b6777000 b6827000 r-xp /usr/lib/libevas.so.1.7.99
b6849000 b685c000 r-xp /usr/lib/libeet.so.1.7.99
b6865000 b68cf000 r-xp /lib/libm-2.13.so
b68d8000 b68e0000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.2
b68e1000 b68e8000 r-xp /usr/lib/libutilX.so.1.1.0
b68f0000 b6a12000 r-xp /usr/lib/libelementary.so.1.7.99
b6a27000 b6a2a000 r-xp /lib/libattr.so.1.1.0
b6a32000 b6a34000 r-xp /usr/lib/libXau.so.6.0.0
b6a3c000 b6a42000 r-xp /lib/librt-2.13.so
b6a4b000 b6a53000 r-xp /lib/libcrypt-2.13.so
b6a83000 b6a86000 r-xp /lib/libcap.so.2.21
b6a8e000 b6a90000 r-xp /usr/lib/libiri.so
b6a98000 b6aad000 r-xp /usr/lib/libxcb.so.1.1.0
b6ab5000 b6ac0000 r-xp /lib/libunwind.so.8.0.1
b6aee000 b6c0b000 r-xp /lib/libc-2.13.so
b6c19000 b6c22000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c2a000 b6c56000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c5f000 b6c62000 r-xp /usr/lib/libbundle.so.0.1.22
b6c6a000 b6c6c000 r-xp /lib/libdl-2.13.so
b6c75000 b6c78000 r-xp /usr/lib/libsmack.so.1.0.0
b6c80000 b6d5a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d63000 b6d77000 r-xp /lib/libpthread-2.13.so
b6d83000 b6d88000 r-xp /usr/lib/libecore_file.so.1.7.99
b6d90000 b6d98000 r-xp /usr/lib/libappcore-efl.so.1.1
b6d9a000 b6d9b000 r-xp /usr/lib/libdlog.so.0.0.0
b6da4000 b6e11000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e1b000 b6e24000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e2c000 b6f12000 r-xp /usr/lib/libX11.so.6.3.0
b6f1d000 b6f1e000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f26000 b6f2a000 r-xp /usr/lib/libsys-assert.so
b6f32000 b6f4f000 r-xp /lib/ld-2.13.so
bece1000 bed02000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5761)
Call Stack Count: 36
 0: Tizen::Ui::_ControlImpl::GetFullScreenSizeInfo() + 0x53 (0xb3b419b4) [/usr/lib/osp/libosp-uifw.so] + 0x2a99b4
 1: Tizen::Ui::Control::AddTouchEventListener(Tizen::Ui::ITouchEventListener&) + 0xa (0xb3b27dab) [/usr/lib/osp/libosp-uifw.so] + 0x28fdab
 2: MyHondanaMainForm::SetCoverFlowView() + 0x98 (0xb2e98814) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0x10814
 3: MyHondanaMainForm::SetSplitPanel() + 0x1bc (0xb2e96ea8) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0xeea8
 4: MyHondanaMainForm::OnInitializing() + 0x6c (0xb2e96a14) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0xea14
 5: Tizen::Ui::_ControlImpl::OnAttachedToMainTree() + 0x22 (0xb3b42563) [/usr/lib/osp/libosp-uifw.so] + 0x2aa563
 6: Tizen::Ui::Controls::_FormImpl::OnAttachedToMainTree() + 0x28 (0xb3cfa6c9) [/usr/lib/osp/libosp-uifw.so] + 0x4626c9
 7: Tizen::Ui::_Control::CallOnAttachedToMainTree(Tizen::Ui::_Control&) + 0xb2 (0xb3b2adbf) [/usr/lib/osp/libosp-uifw.so] + 0x292dbf
 8: Tizen::Ui::_Control::EndAttaching(Tizen::Ui::_Control&) + 0xec (0xb3b2df19) [/usr/lib/osp/libosp-uifw.so] + 0x295f19
 9: Tizen::Ui::_Control::AttachChild(Tizen::Ui::_Control&) + 0x5a (0xb3b3090b) [/usr/lib/osp/libosp-uifw.so] + 0x29890b
10: Tizen::Ui::_ContainerImpl::AddChild(Tizen::Ui::_ControlImpl*, bool) + 0xa4 (0xb3b4da6d) [/usr/lib/osp/libosp-uifw.so] + 0x2b5a6d
11: Tizen::Ui::Container::AddControl(Tizen::Ui::Control*) + 0x26 (0xb3b2517b) [/usr/lib/osp/libosp-uifw.so] + 0x28d17b
12: Tizen::Ui::Container::AddControl(Tizen::Ui::Control const&) + 0x6 (0xb3b25207) [/usr/lib/osp/libosp-uifw.so] + 0x28d207
13: (0xb3dc2b57) [/usr/lib/osp/libosp-uifw.so] + 0x52ab57
14: (0xb3dc349f) [/usr/lib/osp/libosp-uifw.so] + 0x52b49f
15: (0xb3dc601d) [/usr/lib/osp/libosp-uifw.so] + 0x52e01d
16: Tizen::Ui::Scenes::SceneManager::GoForward(Tizen::Ui::Scenes::ForwardSceneTransition const&, Tizen::Base::Collection::IList const*) + 0x18 (0xb3dbab25) [/usr/lib/osp/libosp-uifw.so] + 0x522b25
17: MyHondanaFrame::OnInitializing() + 0x64 (0xb2e9598c) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0xd98c
18: Tizen::Ui::_ControlImpl::OnAttachedToMainTree() + 0x22 (0xb3b42563) [/usr/lib/osp/libosp-uifw.so] + 0x2aa563
19: Tizen::Ui::Controls::_FrameImpl::OnAttachedToMainTree() + 0xa (0xb3cfd5e7) [/usr/lib/osp/libosp-uifw.so] + 0x4655e7
20: Tizen::Ui::_ControlManager::CallOnAttachedToMainTree(Tizen::Ui::_Control&) + 0x76 (0xb3b518c7) [/usr/lib/osp/libosp-uifw.so] + 0x2b98c7
21: Tizen::Ui::_ControlManager::ActivateWindow(Tizen::Ui::_Window&, bool) + 0xcc (0xb3b522f5) [/usr/lib/osp/libosp-uifw.so] + 0x2ba2f5
22: Tizen::Ui::_ControlManager::OpenWindow(Tizen::Ui::_Window&, bool) + 0x2e (0xb3b52507) [/usr/lib/osp/libosp-uifw.so] + 0x2ba507
23: Tizen::Ui::_Window::Open(bool) + 0x3c (0xb3b3f821) [/usr/lib/osp/libosp-uifw.so] + 0x2a7821
24: Tizen::Ui::_WindowImpl::Open(bool) + 0x12 (0xb3b4f897) [/usr/lib/osp/libosp-uifw.so] + 0x2b7897
25: Tizen::App::_UiAppImpl::AddFrame(Tizen::Ui::Controls::Frame const&) + 0x40 (0xb3ef7f35) [/usr/lib/osp/libosp-uifw.so] + 0x65ff35
26: Tizen::App::UiApp::AddFrame(Tizen::Ui::Controls::Frame const&) + 0x14 (0xb3ef72f9) [/usr/lib/osp/libosp-uifw.so] + 0x65f2f9
27: MyHondanaApp::OnAppInitialized() + 0x88 (0xb2e9339c) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0xb39c
28: Tizen::App::_UiAppImpl::OnAppInitialized() + 0x18 (0xb3ef77dd) [/usr/lib/osp/libosp-uifw.so] + 0x65f7dd
29: Tizen::App::_AppImpl::OnService(service_s*, void*) + 0x1da (0xb44aa39f) [/usr/lib/osp/libosp-appfw.so] + 0xf039f
30: (0xb428ebdd) [/usr/lib/libcapi-appfw-application.so.0] + 0x9bdd
31: (0xb6d92f28) [/usr/lib/libappcore-efl.so.1] + 0x2f28
32: (0xb529f94c) [/usr/lib/libappcore-common.so.1] + 0x194c
33: (0xb52a0024) [/usr/lib/libappcore-common.so.1] + 0x2024
34: (0xb652c1a9) [/usr/lib/libaul.so.0] + 0x31a9
dladdr failed 35: (0x81690) (null)
End of Call Stack

Package Information
Package Name: vMEuS5j7iC.MyHondana
Package ID : vMEuS5j7iC
Version: 1.0.0
Package Type: tpk
App Name: MyHondana
App ID: vMEuS5j7iC.MyHondana
Type: Application
Categories: (NULL)

Latest Debug Message Information
--------- beginning of /dev/log_main
iftype(177) > [init_iftype,177] if_index 1, iftype 0
06-27 13:16:36.499 D/RESOURCED( 5711): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent INTERFACE=sit0
06-27 13:16:36.499 D/RESOURCED( 5711): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent IFINDEX=2
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: init_iftype(177) > [init_iftype,177] if_index 2, iftype 0
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent INTERFACE=ip6tnl0
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent IFINDEX=3
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: init_iftype(177) > [init_iftype,177] if_index 3, iftype 0
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent DEVTYPE=datacall
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: convert_iftype(198) > [convert_iftype,198] converting datacall
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: init_iftype(177) > [init_iftype,177] if_index 4, iftype 1
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent DEVTYPE=datacall
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: convert_iftype(198) > [convert_iftype,198] converting datacall
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: init_iftype(177) > [init_iftype,177] if_index 5, iftype 1
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent DEVTYPE=datacall
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: convert_iftype(198) > [convert_iftype,198] converting datacall
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: init_iftype(177) > [init_iftype,177] if_index 6, iftype 1
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent DEVTYPE=wlan
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: convert_iftype(198) > [convert_iftype,198] converting wlan
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: init_iftype(177) > [init_iftype,177] if_index 7, iftype 2
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent DEVTYPE=wlan
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: convert_iftype(198) > [convert_iftype,198] converting wlan
06-27 13:16:36.504 D/RESOURCED( 5711): iface.c: init_iftype(177) > [init_iftype,177] if_index 8, iftype 2
06-27 13:16:36.509 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: main(2165) > server start
06-27 13:16:36.514 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: main(2249) > Main loop is created.
06-27 13:16:36.544 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: main(2254) > pkg_mgr object is created, and request callback is registered.
06-27 13:16:36.544 D/LAUNCH  ( 5711): appcore-efl.c: appcore_efl_main(1372) > [package-manager:Application:main:done]
06-27 13:16:36.554 D/AUL     ( 5711): pkginfo.c: aul_app_get_appid_bypid(129) > second chance
06-27 13:16:36.554 D/AUL     ( 5711): pkginfo.c: aul_app_get_appid_bypid(134) > second change pgid = 2554, pid = 5711
06-27 13:16:36.619 D/STARTER ( 2844): xmonitor.c: _create_cb(146) > [_create_cb:146] Create a window[4200001]
06-27 13:16:36.704 D/APP_CORE( 5711): appcore-efl.c: __before_loop(812) > elm_config_preferred_engine_set is not called
06-27 13:16:36.704 D/APP_CORE( 5711): appcore-efl.c: __before_loop(825) > taskmanage is null
06-27 13:16:36.704 D/AUL     ( 5711): pkginfo.c: aul_app_get_appid_bypid(129) > second chance
06-27 13:16:36.704 D/AUL     ( 5711): pkginfo.c: aul_app_get_appid_bypid(134) > second change pgid = 2554, pid = 5711
06-27 13:16:36.709 D/AUL     ( 5711): app_sock.c: __create_server_sock(135) > pg path - already exists
06-27 13:16:36.709 D/LAUNCH  ( 5711): appcore-efl.c: __before_loop(838) > [package-manager:Platform:appcore_init:done]
06-27 13:16:36.709 D/LAUNCH  ( 5711): appcore-efl.c: __before_loop(848) > [package-manager:Application:create:done]
06-27 13:16:36.714 D/APP_CORE( 5711): appcore-efl.c: __check_wm_rotation_support(586) > Disable window manager rotation
06-27 13:16:36.714 D/PKGMGR  ( 5711): comm_pkg_mgr_server.c: pkgmgr_request(179) > [SECURE_LOG] Call request callback(obj, vMEuS5j7iC_120732477, 1, tpk, vMEuS5j7iC, /usr/etc/package-manager/backend/tpk '-k' 'vMEuS5j7iC_120732477' '-r' 'vMEuS5j7iC' '-q', *ret)
06-27 13:16:36.714 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: req_cb(952) > [SECURE_LOG] >> in callback >> Got request: [vMEuS5j7iC_120732477] [1] [tpk] [vMEuS5j7iC] [/usr/etc/package-manager/backend/tpk '-k' 'vMEuS5j7iC_120732477' '-r' 'vMEuS5j7iC' '-q'] [NbsbfP2hX/dvXeqGT0JcHyug+dY=]
06-27 13:16:36.714 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: req_cb(976) > signal: SIGCHLD succeed
06-27 13:16:36.714 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: req_cb(978) > g_timeout_add_seconds() Added to Main Loop
06-27 13:16:36.714 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: req_cb(984) > req_type=(1) drawing_popup=(0) backend_flag=(0)
06-27 13:16:36.714 E/SECURITY_SERVER( 2611): security-server-main.c: authorize_SS_API_caller_socket(207) > [SECURE_LOG] SS_SMACK: caller_pid=5711, subject=pkgmgr-server, object=security-server::api-middleware, access=w, result=-1, caller_path=/usr/bin/pkgmgr-server
06-27 13:16:36.714 D/SECURITY_SERVER( 2611): security-server-cookie.c: search_cookie_new(287) > [SECURE_LOG] SS_SMACK: caller_pid=5708, subject=pkgmgr, object=pkgmgr::svc, access=r, result=1, caller_path=/usr/bin/pkgcmd
06-27 13:16:36.714 E/SECURITY_SERVER( 5711): security-server-comm.c: recv_generic_response(2162) > Client: return code is not success: 3
06-27 13:16:36.719 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: __check_privilege_by_cookie(247) > security_server[req-type:1] check cookie result = 0, 
06-27 13:16:36.719 D/APP_CORE( 5711): appcore.c: __aul_handler(390) > [APP 5711]     AUL event: AUL_START
06-27 13:16:36.719 D/APP_CORE( 5711): appcore-efl.c: __do_app(346) > [APP 5711] Event: 5
06-27 13:16:36.719 D/APP_CORE( 5711): appcore-efl.c: __do_app(349) > [APP 5711] Event: RESET State: CREATED
06-27 13:16:36.719 D/APP_CORE( 5711): appcore-efl.c: __do_app(375) > [APP 5711] RESET
06-27 13:16:36.719 D/LAUNCH  ( 5711): appcore-efl.c: __do_app(377) > [package-manager:Application:reset:start]
06-27 13:16:36.719 D/LAUNCH  ( 5711): appcore-efl.c: __do_app(382) > [package-manager:Application:reset:done]
06-27 13:16:36.719 D/APP_CORE( 5711): appcore.c: __aul_handler(393) > caller_appid : (null)
06-27 13:16:36.719 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: queue_job(1422) > installer start
06-27 13:16:36.719 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: queue_job(1424) > saved queue status. Now try fork()
06-27 13:16:36.719 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: queue_job(1431) > child forked [5713]
06-27 13:16:36.719 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: queue_job(1519) > parent 
06-27 13:16:36.724 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: queue_job(1431) > child forked [0]
06-27 13:16:36.724 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: queue_job(1435) > before run _get_backend_cmd()
06-27 13:16:36.724 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: _get_backend_cmd(1933) > buffer [backend:/usr/etc/package-manager/backend/]
06-27 13:16:36.724 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: _get_backend_cmd(1935) > path [/usr/etc/package-manager/backend/]
06-27 13:16:36.724 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: _get_backend_cmd(1948) > command [/usr/etc/package-manager/backend/tpk]
06-27 13:16:36.729 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: queue_job(1452) > Try to exec [tpk][/usr/etc/package-manager/backend/tpk]
06-27 13:16:36.729 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: queue_job(1492) > >>>>>> args_vector[0]=/usr/etc/package-manager/backend/tpk
06-27 13:16:36.729 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: queue_job(1492) > >>>>>> args_vector[1]=-k
06-27 13:16:36.729 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: queue_job(1492) > >>>>>> args_vector[2]=vMEuS5j7iC_120732477
06-27 13:16:36.729 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: queue_job(1492) > >>>>>> args_vector[3]=-r
06-27 13:16:36.729 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: queue_job(1492) > >>>>>> args_vector[4]=vMEuS5j7iC
06-27 13:16:36.729 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: queue_job(1492) > >>>>>> args_vector[5]=-q
06-27 13:16:36.729 D/PKGMGR_SERVER( 5713): pkgmgr-server.c: queue_job(1492) > >>>>>> args_vector[6]=(null)
06-27 13:16:36.819 I/RESOURCED( 5713): main.c: librsml_initialize(44) > [librsml_initialize,44] librsml_initialize
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent INTERFACE=lo
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent IFINDEX=1
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: init_iftype(177) > [init_iftype,177] if_index 1, iftype 0
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent INTERFACE=sit0
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent IFINDEX=2
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: init_iftype(177) > [init_iftype,177] if_index 2, iftype 0
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent INTERFACE=ip6tnl0
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent IFINDEX=3
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: init_iftype(177) > [init_iftype,177] if_index 3, iftype 0
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent DEVTYPE=datacall
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: convert_iftype(198) > [convert_iftype,198] converting datacall
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: init_iftype(177) > [init_iftype,177] if_index 4, iftype 1
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent DEVTYPE=datacall
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: convert_iftype(198) > [convert_iftype,198] converting datacall
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: init_iftype(177) > [init_iftype,177] if_index 5, iftype 1
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent DEVTYPE=datacall
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: convert_iftype(198) > [convert_iftype,198] converting datacall
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: init_iftype(177) > [init_iftype,177] if_index 6, iftype 1
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent DEVTYPE=wlan
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: convert_iftype(198) > [convert_iftype,198] converting wlan
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: init_iftype(177) > [init_iftype,177] if_index 7, iftype 2
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: read_iftype(130) > [read_iftype,130] Read from uevent DEVTYPE=wlan
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: convert_iftype(198) > [convert_iftype,198] converting wlan
06-27 13:16:36.819 D/RESOURCED( 5713): iface.c: init_iftype(177) > [init_iftype,177] if_index 8, iftype 2
06-27 13:16:36.829 E/Tizen::Base( 5713): result Tizen::Base::String::SubString(int, Tizen::Base::String&) const(1108) > [E_OUT_OF_RANGE] The startIndex(12) MUST be greater than or equal to 0, and less than the length of this string(12).
06-27 13:16:36.834 E/Tizen::Base::Runtime( 5713): static Tizen::Base::Runtime::_EventManager* Tizen::Base::Runtime::_EventManager::GetCurrentEventManager()(292) > [E_OBJ_NOT_FOUND] This is not OSP thread.
06-27 13:16:36.834 E/Tizen::Base::Runtime( 5713): result Tizen::Base::Runtime::_Event::Initialize()(207) > [E_INVALID_OPERATION] Event manager does not exist.
06-27 13:16:36.834 I/osp-installer( 5713): int main(int, char**)(71) >  # argv[0] = [/usr/etc/package-manager/backend/tpk]
06-27 13:16:36.834 I/osp-installer( 5713): int main(int, char**)(71) >  # argv[1] = [-k]
06-27 13:16:36.834 I/osp-installer( 5713): int main(int, char**)(71) >  # argv[2] = [vMEuS5j7iC_120732477]
06-27 13:16:36.834 I/osp-installer( 5713): int main(int, char**)(71) >  # argv[3] = [-r]
06-27 13:16:36.834 I/osp-installer( 5713): int main(int, char**)(71) >  # argv[4] = [vMEuS5j7iC]
06-27 13:16:36.834 I/osp-installer( 5713): int main(int, char**)(71) >  # argv[5] = [-q]
06-27 13:16:36.834 I/osp-installer( 5713): int main(int, char**)(115) >  # path = [vMEuS5j7iC]
06-27 13:16:36.834 I/osp-installer( 5713): int main(int, char**)(213) > rdsPackage = vMEuS5j7iC
06-27 13:16:36.834 I/osp-installer( 5713): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(141) > ------------------------------------------
06-27 13:16:36.834 I/osp-installer( 5713): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(142) > InstallerManager
06-27 13:16:36.834 I/osp-installer( 5713): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(143) > ------------------------------------------
06-27 13:16:36.834 I/osp-installer( 5713): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(144) >  # operation = [Reinstall]
06-27 13:16:36.834 I/osp-installer( 5713): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(145) >  # path      = [vMEuS5j7iC]
06-27 13:16:36.834 I/osp-installer( 5713): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(146) > ------------------------------------------
06-27 13:16:36.834 I/osp-installer( 5713): InstallerError InstallerManager::Construct(const Tizen::Base::String&, InstallerOperation, InstallerOption, void*, const Tizen::Base::String*)(230) > operation is INSTALLER_OPERATION_REINSTALL
06-27 13:16:36.844 D/PKGMGR  ( 3758): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / start / install
06-27 13:16:36.844 D/PKGMGR  ( 3758): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[start] val[install]
06-27 13:16:36.844 D/PKGMGR  ( 3728): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / start / install
06-27 13:16:36.844 D/PKGMGR  ( 3728): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[start] val[install]
06-27 13:16:36.849 D/PKGMGR  ( 3748): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / start / install
06-27 13:16:36.849 D/PKGMGR  ( 3748): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[start] val[install]
06-27 13:16:36.849 D/PKGMGR  ( 3061): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / start / install
06-27 13:16:36.849 D/PKGMGR  ( 3061): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[start] val[install]
06-27 13:16:36.849 D/PKGMGR  ( 3260): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / start / install
06-27 13:16:36.849 D/PKGMGR  ( 3260): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[start] val[install]
06-27 13:16:36.849 D/CAPI_APPFW_PACKAGE_MANAGER( 3260): package_manager.c: global_event_handler(592) > global_event_handler is called
06-27 13:16:36.849 D/PKGMGR  ( 3149): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / start / install
06-27 13:16:36.849 D/PKGMGR  ( 3149): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[start] val[install]
06-27 13:16:36.849 D/DATA_PROVIDER_MASTER( 3149): pkgmgr.c: start_cb(195) > [SECURE_LOG] [[32mpkgmgr.c/start_cb[0m:195] [vMEuS5j7iC] install
06-27 13:16:36.849 D/DATA_PROVIDER_MASTER( 3149): pkgmgr.c: pkgmgr_cb(438) > [SECURE_LOG] [[32mpkgmgr.c/pkgmgr_cb[0m:438] REQ[1] pkgname[vMEuS5j7iC], type[tpk], key[start], val[install], ret = 0
06-27 13:16:36.849 I/osp-installer( 5713): static bool InstallerManager::SendEvent(InstallationContext*, const Tizen::App::PackageId&, const Tizen::Base::String&, const Tizen::Base::String&)(956) > pkgmgr_installer_send_signal(tpk, vMEuS5j7iC, start, install)
06-27 13:16:36.849 I/osp-installer( 5713): Installer* InstallerManager::CreateInstaller(InstallerType)(281) > InstallerType = [DirectoryInstaller]
06-27 13:16:36.849 I/osp-installer( 5713): static bool InstallerUtil::GetRdsList(const Tizen::App::PackageId&, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*)(832) > .rds_delta file
06-27 13:16:36.849 I/osp-installer( 5713): static bool InstallerUtil::GetRdsList(const Tizen::App::PackageId&, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*)(868) > .rds_delta: line(001)=[#delete]
06-27 13:16:36.849 I/osp-installer( 5713): static bool InstallerUtil::GetRdsList(const Tizen::App::PackageId&, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*)(868) > .rds_delta: line(002)=[#add]
06-27 13:16:36.849 I/osp-installer( 5713): static bool InstallerUtil::GetRdsList(const Tizen::App::PackageId&, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*)(868) > .rds_delta: line(003)=[#modify]
06-27 13:16:36.849 I/osp-installer( 5713): static bool InstallerUtil::GetRdsList(const Tizen::App::PackageId&, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*)(868) > .rds_delta: line(004)=[author-signature.xml]
06-27 13:16:36.849 I/osp-installer( 5713): static bool InstallerUtil::GetRdsList(const Tizen::App::PackageId&, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*)(868) > .rds_delta: line(005)=[signature1.xml]
06-27 13:16:36.849 I/osp-installer( 5713): static bool InstallerUtil::GetRdsList(const Tizen::App::PackageId&, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*, Tizen::Base::Collection::IList*)(868) > .rds_delta: line(006)=[bin/MyHondana.exe]
06-27 13:16:36.859 I/osp-installer( 5713): bool PermissionManager::CopyForRds(InstallationContext*, Tizen::Base::Collection::IList*, bool&)(307) > copy file from[/opt/usr/apps/tmp/vMEuS5j7iC/author-signature.xml] to[/opt/apps/vMEuS5j7iC/author-signature.xml]
06-27 13:16:36.859 I/osp-installer( 5713): static bool InstallerUtil::Remove(const Tizen::Base::String&)(94) > Remove(): file=[/opt/apps/vMEuS5j7iC/author-signature.xml]
06-27 13:16:36.864 I/osp-installer( 5713): bool PermissionManager::CopyForRds(InstallationContext*, Tizen::Base::Collection::IList*, bool&)(307) > copy file from[/opt/usr/apps/tmp/vMEuS5j7iC/signature1.xml] to[/opt/apps/vMEuS5j7iC/signature1.xml]
06-27 13:16:36.864 I/osp-installer( 5713): static bool InstallerUtil::Remove(const Tizen::Base::String&)(94) > Remove(): file=[/opt/apps/vMEuS5j7iC/signature1.xml]
06-27 13:16:36.869 I/osp-installer( 5713): bool PermissionManager::CopyForRds(InstallationContext*, Tizen::Base::Collection::IList*, bool&)(307) > copy file from[/opt/usr/apps/tmp/vMEuS5j7iC/bin/MyHondana.exe] to[/opt/apps/vMEuS5j7iC/bin/MyHondana.exe]
06-27 13:16:36.869 I/osp-installer( 5713): static bool InstallerUtil::Remove(const Tizen::Base::String&)(94) > Remove(): file=[/opt/apps/vMEuS5j7iC/bin/MyHondana.exe]
06-27 13:16:36.934 I/osp-installer( 5713): bool SmackManager::IsSmackEnable()(440) > [smack is on.]
06-27 13:16:36.934 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(540) > [smack] app_label_dir(_, /opt/apps/vMEuS5j7iC)
06-27 13:16:36.939 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(542) > [smack] app_label_dir(_, /opt/apps/vMEuS5j7iC), result = [0]
06-27 13:16:36.939 I/osp-installer( 5713): static bool InstallerUtil::GetRealPath(const Tizen::Base::String&, Tizen::Base::String&)(234) > GetRealPath(): path=[/opt/apps/vMEuS5j7iC], realPath=[/opt/usr/apps/vMEuS5j7iC]
06-27 13:16:36.939 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(540) > [smack] app_label_dir(_, /opt/usr/apps/vMEuS5j7iC)
06-27 13:16:36.949 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(542) > [smack] app_label_dir(_, /opt/usr/apps/vMEuS5j7iC), result = [0]
06-27 13:16:36.954 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.954 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/bin], mode=[0755], appOwner=[false]
06-27 13:16:36.954 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(540) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/bin)
06-27 13:16:36.954 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(542) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/bin), result = [0]
06-27 13:16:36.959 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.959 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/info], mode=[0644], appOwner=[false]
06-27 13:16:36.959 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(540) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/info)
06-27 13:16:36.959 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(542) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/info), result = [0]
06-27 13:16:36.964 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.964 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/res/screen-density-xhigh], mode=[0644], appOwner=[false]
06-27 13:16:36.964 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.969 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/res/screen-size-normal], mode=[0644], appOwner=[false]
06-27 13:16:36.969 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.969 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/res], mode=[0644], appOwner=[false]
06-27 13:16:36.969 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(540) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/res)
06-27 13:16:36.974 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(542) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/res), result = [0]
06-27 13:16:36.974 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.974 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/lib], mode=[0755], appOwner=[false]
06-27 13:16:36.974 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(540) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/lib)
06-27 13:16:36.979 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(542) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/lib), result = [0]
06-27 13:16:36.979 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.979 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/shared/trusted], mode=[0644], appOwner=[false]
06-27 13:16:36.979 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.979 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/shared/res/screen-density-xhigh], mode=[0644], appOwner=[false]
06-27 13:16:36.979 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.979 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/shared/res], mode=[0644], appOwner=[false]
06-27 13:16:36.979 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.979 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/shared/data], mode=[0644], appOwner=[false]
06-27 13:16:36.979 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.979 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/shared], mode=[0644], appOwner=[false]
06-27 13:16:36.979 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(540) > [smack] app_label_dir(*, /opt/apps/vMEuS5j7iC/shared)
06-27 13:16:36.984 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(542) > [smack] app_label_dir(*, /opt/apps/vMEuS5j7iC/shared), result = [0]
06-27 13:16:36.984 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.984 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/shared/res/screen-density-xhigh], mode=[0644], appOwner=[false]
06-27 13:16:36.984 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.984 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/shared/res], mode=[0644], appOwner=[false]
06-27 13:16:36.984 I/osp-installer( 5713): bool SmackManager::AddLabelSharedDir(const Tizen::App::PackageId&, const Tizen::Base::String&)(232) > Invalid Directory = [/opt/apps/vMEuS5j7iC/shared/res]
06-27 13:16:36.984 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.984 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/shared/data], mode=[0644], appOwner=[true]
06-27 13:16:36.989 I/osp-installer( 5713): int SmackManager::AddLabelSharedDir(const char*, const char*, const char*)(573) > [smack] app_label_shared_dir(vMEuS5j7iC, *, /opt/apps/vMEuS5j7iC/shared/data)
06-27 13:16:36.994 I/osp-installer( 5713): int SmackManager::AddLabelSharedDir(const char*, const char*, const char*)(575) > [smack] app_label_shared_dir(vMEuS5j7iC, *, /opt/apps/vMEuS5j7iC/shared/data), result = [0]
06-27 13:16:36.994 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.994 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/shared/trusted], mode=[0644], appOwner=[true]
06-27 13:16:36.999 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(540) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/shared/trusted)
06-27 13:16:36.999 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(542) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/shared/trusted), result = [0]
06-27 13:16:36.999 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:36.999 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/setting], mode=[0666], appOwner=[false]
06-27 13:16:36.999 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(540) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/setting)
06-27 13:16:36.999 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(542) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/setting), result = [0]
06-27 13:16:37.004 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:37.004 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/data/files/files/thumbnail], mode=[0644], appOwner=[true]
06-27 13:16:37.004 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:37.004 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/data/files/files], mode=[0644], appOwner=[true]
06-27 13:16:37.004 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:37.004 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/data/files], mode=[0644], appOwner=[true]
06-27 13:16:37.004 E/Tizen::Io( 5713): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:37.004 I/osp-installer( 5713): static bool InstallerUtil::ChangeDirectoryPermission(const Tizen::Base::String&, int, bool)(368) > path=[/opt/apps/vMEuS5j7iC/data], mode=[0644], appOwner=[true]
06-27 13:16:37.004 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(540) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/data)
06-27 13:16:37.004 I/osp-installer( 5713): int SmackManager::AddLabelDir(const char*, const char*)(542) > [smack] app_label_dir(vMEuS5j7iC, /opt/apps/vMEuS5j7iC/data), result = [0]
06-27 13:16:37.009 I/osp-installer( 5713): virtual InstallerError RdsStep::Run(InstallationContext*)(64) > [STATE_DONE]
06-27 13:16:37.009 I/osp-installer( 5713): InstallerError InstallerManager::Activate()(398) > currentStep is INSTALLER_STEP_RDS
06-27 13:16:37.009 D/PKGMGR  ( 3758): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / install_percent / 100
06-27 13:16:37.009 D/PKGMGR  ( 3758): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[install_percent] val[100]
06-27 13:16:37.009 D/PKGMGR  ( 3728): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / install_percent / 100
06-27 13:16:37.009 D/PKGMGR  ( 3728): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[install_percent] val[100]
06-27 13:16:37.009 D/PKGMGR  ( 3748): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / install_percent / 100
06-27 13:16:37.009 D/PKGMGR  ( 3748): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[install_percent] val[100]
06-27 13:16:37.014 D/PKGMGR  ( 3061): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / install_percent / 100
06-27 13:16:37.014 D/PKGMGR  ( 3061): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[install_percent] val[100]
06-27 13:16:37.014 D/PKGMGR  ( 3260): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / install_percent / 100
06-27 13:16:37.014 D/PKGMGR  ( 3260): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[install_percent] val[100]
06-27 13:16:37.014 D/CAPI_APPFW_PACKAGE_MANAGER( 3260): package_manager.c: global_event_handler(592) > global_event_handler is called
06-27 13:16:37.014 D/CAPI_APPFW_PACKAGE_MANAGER( 3260): package_manager.c: __find_event_info(313) > tmp->req_id 1, event_type -1098245428
06-27 13:16:37.014 D/CAPI_APPFW_PACKAGE_MANAGER( 3260): package_manager.c: __find_event_info(313) > tmp->req_id 1, event_type -1098245476
06-27 13:16:37.014 D/PKGMGR  ( 3149): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / install_percent / 100
06-27 13:16:37.014 D/PKGMGR  ( 3149): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[install_percent] val[100]
06-27 13:16:37.014 D/DATA_PROVIDER_MASTER( 3149): pkgmgr.c: progress_cb(361) > [SECURE_LOG] [[32mpkgmgr.c/progress_cb[0m:361] [vMEuS5j7iC] 100
06-27 13:16:37.014 D/DATA_PROVIDER_MASTER( 3149): pkgmgr.c: pkgmgr_cb(438) > [SECURE_LOG] [[32mpkgmgr.c/pkgmgr_cb[0m:438] REQ[1] pkgname[vMEuS5j7iC], type[tpk], key[install_percent], val[100], ret = 0
06-27 13:16:37.014 I/osp-installer( 5713): static bool InstallerManager::SendEvent(InstallationContext*, const Tizen::App::PackageId&, const Tizen::Base::String&, const Tizen::Base::String&)(956) > pkgmgr_installer_send_signal(tpk, vMEuS5j7iC, install_percent, 100)
06-27 13:16:37.019 D/PKGMGR  ( 3758): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / end / ok
06-27 13:16:37.019 D/PKGMGR  ( 3758): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[end] val[ok]
06-27 13:16:37.029 D/PKGMGR  ( 3728): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / end / ok
06-27 13:16:37.029 D/PKGMGR  ( 3728): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[end] val[ok]
06-27 13:16:37.029 D/PKGMGR  ( 3061): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / end / ok
06-27 13:16:37.029 D/PKGMGR  ( 3061): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[end] val[ok]
06-27 13:16:37.039 D/PKGMGR  ( 3260): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / end / ok
06-27 13:16:37.039 D/PKGMGR  ( 3260): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[end] val[ok]
06-27 13:16:37.039 D/CAPI_APPFW_PACKAGE_MANAGER( 3260): package_manager.c: global_event_handler(592) > global_event_handler is called
06-27 13:16:37.039 D/CAPI_APPFW_PACKAGE_MANAGER( 3260): package_manager.c: __find_event_info(313) > tmp->req_id 1, event_type -1098245428
06-27 13:16:37.039 D/PKGMGR  ( 3149): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / end / ok
06-27 13:16:37.039 D/PKGMGR  ( 3149): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[end] val[ok]
06-27 13:16:37.039 D/DATA_PROVIDER_MASTER( 3149): pkgmgr.c: end_cb(395) > [SECURE_LOG] [[32mpkgmgr.c/end_cb[0m:395] [vMEuS5j7iC] ok
06-27 13:16:37.039 D/DATA_PROVIDER_MASTER( 3149): package.c: install_cb(1303) > [SECURE_LOG] [[32mpackage.c/install_cb[0m:1303] Processed 0 packages
06-27 13:16:37.039 D/DATA_PROVIDER_MASTER( 3149): pkgmgr.c: pkgmgr_cb(438) > [SECURE_LOG] [[32mpkgmgr.c/pkgmgr_cb[0m:438] REQ[1] pkgname[vMEuS5j7iC], type[tpk], key[end], val[ok], ret = 0
06-27 13:16:37.039 D/PKGMGR  ( 3748): comm_client_dbus.c: _on_signal_handle_filter(100) > [SECURE_LOG] Got signal: vMEuS5j7iC_120732477 / tpk / vMEuS5j7iC / end / ok
06-27 13:16:37.039 D/PKGMGR  ( 3748): pkgmgr.c: __status_callback(374) > [SECURE_LOG] __status_callback() req_id[vMEuS5j7iC_120732477] pkg_type[tpk] pkgid[vMEuS5j7iC]key[end] val[ok]
06-27 13:16:37.039 I/SAMSUNG_CONTEXT_SERVICE( 3748): virtual void Samsung::Context::_AppLoggingService::OnPackageInstallationCompleted(const Tizen::App::PackageId&, Tizen::App::Package::PackageInstallationResult)(209) > [SECURE_LOG] Thread name : CtxtAppLoggingService, install packageId : vMEuS5j7iC, installationResult : 0
06-27 13:16:37.044 I/SAMSUNG_CONTEXT_SERVICE( 3748): void Samsung::Context::_AppLoggingService::SendAppLog(RequestId, const Tizen::App::PackageId&)(162) > SendAppLog
06-27 13:16:37.044 I/SAMSUNG_CONTEXT_SERVICE( 3748): virtual void Samsung::Context::_AppLoggingService::OnUserEventReceivedN(RequestId, Tizen::Base::Collection::IList*)(249) > [SECURE_LOG] OnUserEventReceivedN start (requestId: 1)
06-27 13:16:37.044 I/SAMSUNG_CONTEXT_SERVICE( 3748): void Samsung::Context::_AppLoggingService::AppInstallLogging(const Tizen::App::PackageId&, int)(185) > [SECURE_LOG] App Install Logging. Thread: CtxtAppLoggingService, packageId:vMEuS5j7iC, Install type:1
06-27 13:16:37.044 I/SAMSUNG_CONTEXT_SERVICE( 3748): Samsung::Context::_LocationContext* Samsung::Context::_LocationContextAnalyzer::GetLocationContextN(int, int)(138) > Wait the current location context - timeout(0).
06-27 13:16:37.044 I/SAMSUNG_CONTEXT_SERVICE( 3748): virtual void Samsung::Context::_LocationContextAnalyzer::OnUserEventReceivedN(RequestId, Tizen::Base::Collection::IList*)(278) > Lca handles event(requestId: -1, argCount: 2)
06-27 13:16:37.044 I/SAMSUNG_CONTEXT_SERVICE( 3748): virtual void Samsung::Context::_LocationContextAnalyzer::OnUserEventReceivedN(RequestId, Tizen::Base::Collection::IList*)(286) > Handle internal request(command: get-location-context)
06-27 13:16:37.044 I/PRIVACY-MANAGER-CLIENT( 3748): PrivacyChecker.cpp: checkWithPrivilege(285) > enter
06-27 13:16:37.044 I/osp-installer( 5713): static bool InstallerManager::SendEvent(InstallationContext*, const Tizen::App::PackageId&, const Tizen::Base::String&, const Tizen::Base::String&)(956) > pkgmgr_installer_send_signal(tpk, vMEuS5j7iC, end, ok)
06-27 13:16:37.044 I/PRIVACY-MANAGER-CLIENT( 3748): PrivacyChecker.cpp: checkWithPrivilege(296) > leave
06-27 13:16:37.044 I/osp-installer( 5713): void InstallerManager::PrintResult()(770) > ==========================================
06-27 13:16:37.044 I/osp-installer( 5713): void InstallerManager::PrintResult()(771) >  # operation = Reinstall
06-27 13:16:37.044 I/PRIVACY-MANAGER-CLIENT( 3748): PrivacyChecker.cpp: check(250) > enter nas9xepmna: http://tizen.org/privacy/location
06-27 13:16:37.044 I/osp-installer( 5713): void InstallerManager::PrintResult()(772) >  # version=[20130619.2]
06-27 13:16:37.044 I/PRIVACY-MANAGER-CLIENT( 3748): PrivacyChecker.cpp: check(207) > enter
06-27 13:16:37.044 I/osp-installer( 5713): void InstallerManager::PrintResult()(773) >  # Package   = [vMEuS5j7iC]
06-27 13:16:37.044 I/osp-installer( 5713): void InstallerManager::PrintResult()(774) >  # MainApp   = [Unknown]
06-27 13:16:37.044 I/osp-installer( 5713): void InstallerManager::PrintResult()(775) >  # Time      = [208]ms
06-27 13:16:37.044 I/osp-installer( 5713): void InstallerManager::PrintError(int)(871) >  # Error     = Success(0)
06-27 13:16:37.044 I/osp-installer( 5713): void InstallerManager::PrintResult()(777) > ==========================================
06-27 13:16:37.044 I/osp-installer( 5713): static bool InstallerUtil::Remove(const Tizen::Base::String&)(76) > Remove(): [] - No such file or directory[errno(2)]: skip
06-27 13:16:37.044 D/PRIVACY-MANAGER-CLIENT( 3748): PrivacyChecker.cpp: check(225) > OK
06-27 13:16:37.044 I/PRIVACY-MANAGER-CLIENT( 3748): PrivacyChecker.cpp: check(277) > leave
06-27 13:16:37.044 I/osp-installer( 5713): bool __osp_installer_report_result(const Tizen::App::PackageId&, int)(254) > ------------------------------------------
06-27 13:16:37.054 I/osp-installer( 5713): bool __osp_installer_report_result(const Tizen::App::PackageId&, int)(255) > osp_installer_report_result
06-27 13:16:37.054 I/osp-installer( 5713): bool __osp_installer_report_result(const Tizen::App::PackageId&, int)(256) >  # request_type = [6]
06-27 13:16:37.054 I/osp-installer( 5713): bool __osp_installer_report_result(const Tizen::App::PackageId&, int)(257) >  # request_info = [vMEuS5j7iC]
06-27 13:16:37.054 I/osp-installer( 5713): bool __osp_installer_report_result(const Tizen::App::PackageId&, int)(258) >  # session = [vMEuS5j7iC_120732477]
06-27 13:16:37.054 I/osp-installer( 5713): bool __osp_installer_report_result(const Tizen::App::PackageId&, int)(261) >  # package = [vMEuS5j7iC]
06-27 13:16:37.054 I/osp-installer( 5713): bool __osp_installer_report_result(const Tizen::App::PackageId&, int)(263) >  # errorType = [0]
06-27 13:16:37.054 I/osp-installer( 5713): bool __osp_installer_report_result(const Tizen::App::PackageId&, int)(264) > ------------------------------------------
06-27 13:16:37.074 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: sighandler(910) > child exit [5713]
06-27 13:16:37.074 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: sighandler(912) > child NORMAL exit [5713]
06-27 13:16:37.079 E/Tizen::Io( 3061): static bool Tizen::Io::File::IsFileExist(const Tizen::Base::String&)(300) > [E_INVALID_ARG] Given filePath length is zero or exceeds system limitations.
06-27 13:16:37.084 E/Tizen::Locations( 3748): static Tizen::Locations::Location Tizen::Locations::_LocationProviderImpl::GetLastKnownLocation()(367) > [E_USER_NOT_CONSENTED] The user has disabled the required settings.
06-27 13:16:37.084 I/SAMSUNG_CONTEXT_SERVICE( 3748): Samsung::Context::_LocationContext* Samsung::Context::_LocationContextAnalyzer::GetLocationContextN(int, int)(141) > Awake from the waiting.
06-27 13:16:37.084 E/SAMSUNG_CONTEXT_SERVICE( 3748): Samsung::Context::_LocationContext* Samsung::Context::_LocationContextAnalyzer::GetLocationContextN(int, int)(143) > [E_SYSTEM] No location context available.
06-27 13:16:37.084 E/SAMSUNG_CONTEXT_SERVICE( 3748): result Samsung::Context::_LogDbManagerServer::GetPlaceAndLocation(Tizen::Base::String&, Tizen::Base::String&, Tizen::Base::String&, double&, double&)(2374) > [E_SYSTEM] A system error has occurred. _LocationContext::GetLocationContextN(5) has return null
06-27 13:16:37.084 I/SAMSUNG_CONTEXT_SERVICE( 3748): void Samsung::Context::_LogDbManagerServer::GetDeviceStatus(long long unsigned int&)(2326) > Device Status = 0xa395565240
06-27 13:16:37.084 I/PRIVACY-MANAGER-CLIENT( 3748): PrivacyChecker.cpp: checkWithPrivilege(285) > enter
06-27 13:16:37.084 I/PRIVACY-MANAGER-CLIENT( 3748): PrivacyChecker.cpp: checkWithPrivilege(296) > leave
06-27 13:16:37.084 I/PRIVACY-MANAGER-CLIENT( 3748): PrivacyChecker.cpp: check(250) > enter nas9xepmna: http://tizen.org/privacy/account
06-27 13:16:37.084 I/PRIVACY-MANAGER-CLIENT( 3748): PrivacyChecker.cpp: check(207) > enter
06-27 13:16:37.084 D/PRIVACY-MANAGER-CLIENT( 3748): PrivacyChecker.cpp: check(225) > OK
06-27 13:16:37.084 I/PRIVACY-MANAGER-CLIENT( 3748): PrivacyChecker.cpp: check(277) > leave
06-27 13:16:37.084 I/SAMSUNG_CONTEXT_SERVICE( 3748): result Samsung::Context::_LogDbManagerServer::GetSamsungAccount(Tizen::Base::String&)(2352) > [SECURE_LOG] Samsung Account Id = 
06-27 13:16:37.084 I/SAMSUNG_CONTEXT_SERVICE( 3748): result Samsung::Context::_LogDbManagerServer::InsertExecuteSql(const Tizen::Base::String&, const Tizen::Base::String&, long long int&)(614) > [SECURE_LOG] Sql statement INSERT INTO 'ACTIVITY_LOG_nas9xepmna_MANAGE_APP' (TYPE, APP_ID, PLACE_ID, PLACE_NAME, PLACE_CATEGORY, LONGITUDE, LATITUDE, DEVICE_STATUS, SAMSUNG_ACCOUNT_ID, TIME_ZONE) VALUES(1, 'vMEuS5j7iC', '', '', '', -200.00000000, -200.00000000, 702585131584, '', '+0900')
06-27 13:16:37.089 E/Tizen::Io( 3061): result Tizen::Io::_DbEnumeratorImpl::GetStringAt(int, Tizen::Base::String&) const(879) > [E_TYPE_MISMATCH] Trying to access column of different type.
06-27 13:16:37.089 E/Tizen::Io( 3061): result Tizen::Io::_DbEnumeratorImpl::GetIntAt(int, int&) const(810) > [E_TYPE_MISMATCH] Trying to access column of different type.
06-27 13:16:37.089 E/Tizen::Io( 3061): result Tizen::Io::_DbEnumeratorImpl::GetStringAt(int, Tizen::Base::String&) const(879) > [E_TYPE_MISMATCH] Trying to access column of different type.
06-27 13:16:37.099 I/SAMSUNG_CONTEXT_SERVICE( 3748): long long int Samsung::Context::_ContextDbManager::GetLastInsertRowId(const Tizen::Base::String&)(289) > [SECURE_LOG] Last inserted row id: 4
06-27 13:16:37.099 I/SAMSUNG_CONTEXT_SERVICE( 3748): void Samsung::Context::_AppLoggingService::AppInstallLogging(const Tizen::App::PackageId&, int)(202) > [SECURE_LOG] Insert is called.  reqId : -1
06-27 13:16:37.104 E/Tizen::Io( 3061): static bool Tizen::Io::File::IsFileExist(const Tizen::Base::String&)(300) > [E_INVALID_ARG] Given filePath length is zero or exceeds system limitations.
06-27 13:16:37.104 E/Tizen::App( 3061): void Tizen::App::_ConditionManagerStub::OnInstallComplete(const Tizen::App::AppId&)(132) > failed to GetAppLaunchConditionListN(vMEuS5j7iC.MyHondana)
06-27 13:16:38.539 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: exit_server(1247) > exit_server Start
06-27 13:16:38.539 D/AUL     ( 5711): app_sock.c: __app_send_raw_with_noreply(344) > pid(-2) : cmd(19)
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] com.samsung.volume, 3014, 0
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] vo6Mxic2lx.DecoEmojiManager, 3496, 0
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] docomo2007.ScheduleDataBridgeService, 3731, 0
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] com.samsung.menu-screen, 3734, 0
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] docomo3300.SaigaibanService, 3737, 0
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] docomo1003.DMarketProvider, 3740, 0
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] nas9xepmna.context-service, 3748, 0
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] docomo2009.CloudServiceApp, 3753, 0
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] docomo3024.ApplicationManagerService, 3758, 0
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] docomo5001.DocomoWifiConnectService, 3762, 0
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] docomo2000.AreaMail, 3769, 0
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] com.samsung.setting, 4263, 0
06-27 13:16:38.539 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(106) > [SECURE_LOG] com.samsung.draglock, 5477, 0
06-27 13:16:38.554 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: main(2259) > Quit main loop.
06-27 13:16:38.559 D/PKGMGR_SERVER( 5711): pkgmgr-server.c: main(2268) > package manager server terminated.
06-27 13:16:41.724 E/SECURITY_SERVER( 2611): security-server-main.c: security_server_thread(1647) > Unknown msg ID :35
06-27 13:16:41.724 E/SECURITY_SERVER( 2763): security-server-comm.c: recv_generic_response(2162) > Client: return code is not success: 1
06-27 13:16:41.724 E/SECURITY_SERVER( 2763): security-server-client.c: recv_exec_path_response(161) > Failed to get response: -2
06-27 13:16:41.724 E/SECURITY_SERVER( 2763): security-server-client.c: get_exec_path(214) > Client: Recv failed: -2
06-27 13:16:41.724 E/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_sockfd(619) > Failed to read executable path for process 5757
06-27 13:16:41.729 E/SECURITY_SERVER( 2611): security-server-main.c: authorize_SS_API_caller_socket(207) > [SECURE_LOG] SS_SMACK: caller_pid=2763, subject=aul, object=security-server::api-middleware, access=w, result=-1, caller_path=/usr/bin/amd
06-27 13:16:41.729 D/SECURITY_SERVER( 2611): security-server-main.c: process_pid_privilege_check(1117) > [SECURE_LOG] Subject label of client PID 5757 is: aul
06-27 13:16:41.729 E/SECURITY_SERVER( 2611): security-server-main.c: process_pid_privilege_check(1129) > [SECURE_LOG] SS_SMACK: caller_pid=5757, subject=aul, object=aul::launch, access=x, result=0, caller_path=/usr/bin/launch_app
06-27 13:16:41.729 E/SECURITY_SERVER( 2763): security-server-comm.c: recv_generic_response(2162) > Client: return code is not success: 4
06-27 13:16:41.729 E/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1395) > Client: There is no privilege match
06-27 13:16:41.729 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_sockfd(629) > [SECURE_LOG] security_server_check_privilege_by_pid returned 0
06-27 13:16:41.729 E/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_sockfd(633) > [SECURE_LOG] SS_SMACK: caller_pid=5757, subject=aul, object=aul::launch, access=x, result=0, caller_path=(null)
06-27 13:16:41.729 E/AUL_AMD ( 2763): amd_request.c: __request_handler(324) > launch request has been denied by smack
06-27 13:16:41.734 D/AUL     ( 2763): pkginfo.c: aul_app_get_appid_bypid(129) > second chance
06-27 13:16:41.734 D/AUL     ( 2763): pkginfo.c: aul_app_get_appid_bypid(134) > second change pgid = 5757, pid = 5757
06-27 13:16:41.754 D/AUL_AMD ( 2763): amd_launch.c: _start_app(842) > *******[effect_mode] Mode : 0
06-27 13:16:41.754 D/AUL_AMD ( 2763):  
06-27 13:16:41.754 D/AUL     ( 2763): app_sock.c: __app_send_raw(262) > pid(-1) : cmd(0)
06-27 13:16:41.754 D/AUL_PAD ( 2822): launchpad.c: __launchpad_main_loop(674) > [SECURE_LOG] pkg name : vMEuS5j7iC.MyHondana
06-27 13:16:41.754 D/AUL_PAD ( 2822): launchpad.c: __modify_bundle(429) > parsing app_path: No arguments
06-27 13:16:41.759 D/AUL_PAD ( 2822): launchpad.c: __launchpad_main_loop(728) > [SECURE_LOG] ==> real launch pid : 5761 /opt/apps/vMEuS5j7iC/bin/MyHondana
06-27 13:16:41.759 D/AUL_PAD ( 2822): launchpad.c: __send_result_to_caller(600) > -- now wait to change cmdline --
06-27 13:16:41.759 D/AUL_PAD ( 5761): launchpad.c: __launchpad_main_loop(701) > lock up test log(no error) : fork done
06-27 13:16:41.759 D/AUL_PAD ( 5761): launchpad.c: __launchpad_main_loop(712) > lock up test log(no error) : prepare exec - first done
06-27 13:16:41.759 I/ENV_CONFIG( 5761): osp-env-config.c: do_pre_exec(654) > do_pre_exec() is called, package name: vMEuS5j7iC.MyHondana, binary path: /opt/apps/vMEuS5j7iC/bin/MyHondana
06-27 13:16:41.759 I/ENV_CONFIG( 5761): osp-env-config.c: get_app_rootpath_from_path(87) > input bin_path: /opt/apps/vMEuS5j7iC/bin/MyHondana
06-27 13:16:41.759 I/ENV_CONFIG( 5761): osp-env-config.c: get_package_id_from_app_rootpath(113) > package id: vMEuS5j7iC
06-27 13:16:41.759 I/ENV_CONFIG( 5761): osp-env-config.c: do_pre_exec(679) > package: vMEuS5j7iC.MyHondana (vMEuS5j7iC), binary: /opt/apps/vMEuS5j7iC/bin/MyHondana, OSP compat: 0
06-27 13:16:41.764 I/ENV_CONFIG( 5761): osp-env-config.c: do_pre_exec(707) > [data_caging] do_pre_exec() succeeded.
06-27 13:16:41.764 D/AUL_PAD ( 5761): preexec.h: __preexec_run(161) > called dl_do_pre_exe() type: tpk
06-27 13:16:41.764 D/AUL_PAD ( 5761): launchpad.c: __prepare_exec(199) > [SECURE_LOG] pkg_name : vMEuS5j7iC.MyHondana / pkg_type : tpk / app_path : /opt/apps/vMEuS5j7iC/bin/MyHondana 
06-27 13:16:41.764 D/PRIVILEGE_CONTROL( 5761): privilege-control.c: set_app_privilege(755) > [SECURE_LOG] Function params: name = vMEuS5j7iC.MyHondana, type = tpk, path = /opt/apps/vMEuS5j7iC/bin/MyHondana
06-27 13:16:41.764 D/PRIVILEGE_CONTROL( 5761): privilege-control.c: set_dac(522) > [SECURE_LOG] setenv(): USER = app, HOME = /opt/home/app
06-27 13:16:41.764 D/AUL_PAD ( 5761): launchpad.c: __launchpad_main_loop(722) > lock up test log(no error) : prepare exec - second done
06-27 13:16:41.764 D/AUL_PAD ( 5761): launchpad.c: __real_launch(277) > [SECURE_LOG] input argument 0 : /opt/apps/vMEuS5j7iC/bin/MyHondana##
06-27 13:16:41.764 D/AUL_PAD ( 5761): launchpad.c: __real_launch(277) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-27 13:16:41.764 D/AUL_PAD ( 5761): launchpad.c: __real_launch(277) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-27 13:16:41.764 D/AUL_PAD ( 5761): launchpad.c: __real_launch(277) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADEzNzIzMDY2MDEvNzI5MDg1AA==##
06-27 13:16:41.769 D/AUL_PAD ( 5761): launchpad.c: __real_launch(277) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-27 13:16:41.769 D/AUL_PAD ( 5761): launchpad.c: __real_launch(277) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA1NzU3AA==##
06-27 13:16:41.769 D/AUL_PAD ( 5761): launchpad.c: __real_launch(280) > lock up test log(no error) : setup argument done
06-27 13:16:41.769 D/LAUNCH  ( 5761): launchpad.c: __real_launch(283) > [/opt/apps/vMEuS5j7iC/bin/MyHondana:Platform:launchpad:done]
06-27 13:16:41.769 I/LOADER  ( 5761): uiapp_loader.c: main(297) > Initializeing : argc 6, argv 0x6e718.
06-27 13:16:41.774 D/LOADER  ( 5761): uiapp_loader.c: print_args(71) > 0th arg : [/opt/apps/vMEuS5j7iC/bin/MyHondana]
06-27 13:16:41.774 D/LOADER  ( 5761): uiapp_loader.c: print_args(71) > 1th arg : [`zaybxcwdveuftgsh`]
06-27 13:16:41.774 D/LOADER  ( 5761): uiapp_loader.c: print_args(71) > 2th arg : [__AUL_STARTTIME__]
06-27 13:16:41.774 D/LOADER  ( 5761): uiapp_loader.c: print_args(71) > 3th arg : [NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADEzNzIzMDY2MDEvNzI5MDg1AA==]
06-27 13:16:41.774 D/LOADER  ( 5761): uiapp_loader.c: print_args(71) > 4th arg : [__AUL_CALLER_PID__]
06-27 13:16:41.774 D/LOADER  ( 5761): uiapp_loader.c: print_args(71) > 5th arg : [KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA1NzU3AA==]
06-27 13:16:41.774 I/LOADER  ( 5761): uiapp_loader.c: get_appid_executable_name_from_path(215) > Exec is MyHondana
06-27 13:16:41.774 I/LOADER  ( 5761): uiapp_loader.c: get_appid_executable_name_from_path(226) > PackageId is vMEuS5j7iC
06-27 13:16:41.774 I/LOADER  ( 5761): uiapp_loader.c: get_package_name_from_appid_executable_name(239) > Package is vMEuS5j7iC
06-27 13:16:41.774 I/LOADER  ( 5761): uiapp_loader.c: main(304) > Osp package vMEuS5j7iC.
06-27 13:16:41.774 I/LOADER  ( 5761): uiapp_loader.c: get_dir_fd_from_path(277) > Directory path : /opt/apps/vMEuS5j7iC, fd : 6.
06-27 13:16:41.809 I/RESOURCED( 2763): proc-stat.c: proc_cgroup_send_status(818) > [proc_cgroup_send_status,818] CALL PROC_CGROUP_SEND_STATUS
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] com.samsung.volume, 3014, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] vo6Mxic2lx.DecoEmojiManager, 3496, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] docomo2007.ScheduleDataBridgeService, 3731, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] com.samsung.menu-screen, 3734, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] docomo3300.SaigaibanService, 3737, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] docomo1003.DMarketProvider, 3740, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] nas9xepmna.context-service, 3748, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] docomo2009.CloudServiceApp, 3753, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] docomo3024.ApplicationManagerService, 3758, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] docomo5001.DocomoWifiConnectService, 3762, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] docomo2000.AreaMail, 3769, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] com.samsung.setting, 4263, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] com.samsung.draglock, 5477, 0
06-27 13:16:41.809 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(65) > [SECURE_LOG] vMEuS5j7iC.MyHondana, 5761, 0
06-27 13:16:41.809 D/APP_CHECKER( 2763): ac_server.c: __check_launch_privilege(85) > [SECURE_LOG] type : tpk / so name : libmdm-appchecker.so / func : b6c1583d
06-27 13:16:41.809 D/RESOURCED( 3491): proc-noti.c: recv_str(87) > [recv_str,87] str is null
06-27 13:16:41.809 D/RESOURCED( 3491): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2763
06-27 13:16:41.814 D/RESOURCED( 3491): proc-main.c: resourced_proc_action(103) > [resourced_proc_action,103] appid vMEuS5j7iC.MyHondana, pid 5761, type 4 
06-27 13:16:41.814 D/RESOURCED( 3491): proc-main.c: resourced_proc_action(114) > [SECURE_LOG] [resourced_proc_action,114] launch request vMEuS5j7iC.MyHondana, 5761
06-27 13:16:41.814 I/RESOURCED( 3491): cgroup.c: make_net_cls_cgroup_with_pid(199) > [SECURE_LOG] [make_net_cls_cgroup_with_pid,199] pkg: vMEuS5j7iC.MyHondana; pid: 5761
06-27 13:16:41.814 D/RESOURCED( 3491): cgroup.c: _place_pid_to_cgroup_by_task(153) > [SECURE_LOG] [_place_pid_to_cgroup_by_task,153] file_name_buf /sys/fs/cgroup/net_cls/vMEuS5j7iC.MyHondana/tasks, pid 5761
06-27 13:16:41.814 D/RESOURCED( 3491): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
06-27 13:16:41.819 D/AUL_PAD ( 2822): sigchild.h: __signal_block_sigchld(229) > SIGCHLD blocked
06-27 13:16:41.834 D/AUL_PAD ( 2822): sigchild.h: __send_app_launch_signal(112) > send launch signal done
06-27 13:16:41.834 D/AUL_PAD ( 2822): sigchild.h: __signal_unblock_sigchld(241) > SIGCHLD unblocked
06-27 13:16:41.839 D/AUL     ( 3061): pkginfo.c: aul_app_get_appid_bypid(125) > [SECURE_LOG] appid for 5761 is vMEuS5j7iC.MyHondana
06-27 13:16:41.954 D/HEYNOTI ( 5761): heynoti.c: heynoti_subscribe(398) > add watch: [/opt/share/noti/power_off_start]
06-27 13:16:41.964 D/AUL     ( 5761): pkginfo.c: aul_app_get_appid_bypid(125) > [SECURE_LOG] appid for 5761 is vMEuS5j7iC.MyHondana
06-27 13:16:41.964 D/LAUNCH  ( 5761): appcore-efl.c: appcore_efl_main(1372) > [MyHondana:Application:main:done]
06-27 13:16:41.969 D/AUL     ( 5761): pkginfo.c: aul_app_get_appid_bypid(125) > [SECURE_LOG] appid for 5761 is vMEuS5j7iC.MyHondana
06-27 13:16:42.009 D/STARTER ( 2844): xmonitor.c: _create_cb(146) > [_create_cb:146] Create a window[4200001]
06-27 13:16:42.014 D/APP_CORE( 5761): appcore-efl.c: __before_loop(815) > elm_config_preferred_engine_set : opengl_x11
06-27 13:16:42.014 D/APP_CORE( 5761): appcore-efl.c: __before_loop(831) > taskmanage is true true
06-27 13:16:42.019 D/AUL     ( 5761): pkginfo.c: aul_app_get_appid_bypid(125) > [SECURE_LOG] appid for 5761 is vMEuS5j7iC.MyHondana
06-27 13:16:42.019 D/AUL     ( 5761): app_sock.c: __create_server_sock(135) > pg path - already exists
06-27 13:16:42.019 D/LAUNCH  ( 5761): appcore-efl.c: __before_loop(838) > [MyHondana:Platform:appcore_init:done]
06-27 13:16:42.064 E/Tizen::Base::Collection( 3061): virtual const Tizen::Base::Object* Tizen::Base::Collection::ArrayList::GetAt(int) const(241) > [E_OUT_OF_RANGE] The index(2) MUST be greater than or equal to 0 and less than the number of elements(2).
06-27 13:16:42.139 D/LAUNCH  ( 5761): appcore-efl.c: __before_loop(848) > [MyHondana:Application:create:done]
06-27 13:16:42.139 D/APP_CORE( 5761): appcore-efl.c: __check_wm_rotation_support(586) > Disable window manager rotation
06-27 13:16:42.139 D/APP_CORE( 5761): appcore.c: __aul_handler(390) > [APP 5761]     AUL event: AUL_START
06-27 13:16:42.139 D/APP_CORE( 5761): appcore-efl.c: __do_app(346) > [APP 5761] Event: 5
06-27 13:16:42.139 D/APP_CORE( 5761): appcore-efl.c: __do_app(349) > [APP 5761] Event: RESET State: CREATED
06-27 13:16:42.139 D/APP_CORE( 5761): appcore-efl.c: __do_app(375) > [APP 5761] RESET
06-27 13:16:42.139 D/LAUNCH  ( 5761): appcore-efl.c: __do_app(377) > [MyHondana:Application:reset:start]
06-27 13:16:42.139 D/APP_SVC ( 5761): appsvc.c: __set_bundle(129) > __set_bundle
06-27 13:16:42.154 E/Tizen::Io( 5761): static bool Tizen::Io::File::IsFileExist(const Tizen::Base::String&)(300) > [E_INVALID_ARG] Given filePath length is zero or exceeds system limitations.
06-27 13:16:42.154 E/MyHondana( 5761): result Tizen::Base::Collection::HashMapT<KeyType, ValueType>::Add(const KeyType&, const ValueType&) [with KeyType = Tizen::Ui::_Resource::ResourceKey, ValueType = Tizen::Ui::_Resource::ResourceItem*, result = long unsigned int](418) > [E_OBJ_ALREADY_EXIST] The key is already exist in this collection.
06-27 13:16:42.159 E/MyHondana( 5761): result Tizen::Base::Collection::HashMapT<KeyType, ValueType>::Add(const KeyType&, const ValueType&) [with KeyType = Tizen::Ui::_Resource::ResourceKey, ValueType = Tizen::Ui::_Resource::ResourceItem*, result = long unsigned int](418) > [E_OBJ_ALREADY_EXIST] The key is already exist in this collection.
06-27 13:16:42.174 D/CoreGL  ( 5761): coregl.c: coregl_initialize(194) >  [CoreGL] <5761> (Mon May 13 14:17:46 UTC 2013) Library initializing...
06-27 13:16:42.184 D/CoreGL  ( 5761): coregl.c: coregl_initialize(200) >   -> Completed
06-27 13:16:42.184 D/CoreGL  ( 5761): coregl_fastpath.c: init_modules_fastpath(62) >  [CoreGL] <Fastpath> : 
06-27 13:16:42.184 D/CoreGL  ( 5761): coregl_fastpath.c: init_modules_fastpath(80) >  (0) Default API path enabled...
06-27 13:16:42.189 D/STARTER ( 2844): xmonitor.c: _create_cb(146) > [_create_cb:146] Create a window[4200003]
06-27 13:16:42.214 D/STARTER ( 2844): xmonitor.c: _create_cb(146) > [_create_cb:146] Create a window[4200004]
06-27 13:16:42.224 D/STARTER ( 2844): xmonitor.c: _create_cb(146) > [_create_cb:146] Create a window[4200005]
06-27 13:16:42.244 D/STARTER ( 2844): xmonitor.c: _create_cb(146) > [_create_cb:146] Create a window[4200009]
06-27 13:16:42.264 D/STARTER ( 2844): xmonitor.c: _create_cb(146) > [_create_cb:146] Create a window[420000a]
06-27 13:16:42.279 E/Tizen::Ui( 5761): bool Tizen::Ui::_Control::IsVisible() const(2900) > [E_SYSTEM] This control should be attached to the main tree.
06-27 13:16:42.344 E/Tizen::Io( 5761): result Tizen::Io::_DirEnumeratorImpl::MoveNext()(143) > [E_END_OF_FILE] End of directory entries
06-27 13:16:42.384 E/Tizen::Ui::Animations( 5761): static result Tizen::Ui::Animations::AnimationTransaction::Stop(int)(79) > [E_INVALID_ARG] Invalid argument(s) is used. transactionId = 0
06-27 13:16:42.384 E/Tizen::Ui::Animations( 5761): static result Tizen::Ui::Animations::AnimationTransaction::Stop(int)(79) > [E_INVALID_ARG] Invalid argument(s) is used. transactionId = 0
06-27 13:16:42.384 E/Tizen::Ui( 5761): result Tizen::Ui::_Control::StartAttaching(Tizen::Ui::_Control&, Tizen::Ui::_ControlArea)(1716) > [E_INVALID_ARG] Unable to add the child which already has another parent.
06-27 13:16:42.389 E/Tizen::Ui( 5761): result Tizen::Ui::_ContainerImpl::AddChild(Tizen::Ui::_ControlImpl*, bool)(174) > [E_INVALID_ARG] propagated.
06-27 13:16:42.389 E/Tizen::Ui( 5761): result Tizen::Ui::Container::AddControl(Tizen::Ui::Control*)(150) > [E_INVALID_ARG] Propagating.
06-27 13:16:42.389 E/Tizen::Ui( 5761): result Tizen::Ui::Container::AddControl(Tizen::Ui::Control*)(145) > [E_INVALID_ARG] pControl is null.
06-27 13:16:42.549 W/CRASH_WORKER( 5766): crash-worker.c: crash_worker(1079) > [SECURE_LOG] crash_worker start(SMyHondana1372306602)
--------- beginning of /dev/log_system
ed ACCELEROMETER_SENSOR(0) for enlightenment(2639)
06-27 13:10:45.509 I/SENSOR  ( 2639): client.cpp:sf_stop(1805)> enlightenment(2639) stops with ACCELEROMETER_SENSOR[0]
06-27 13:10:45.509 I/SENSOR  ( 2639): client.cpp:lcd_off_cb(814)> Stopped event_type: ACCELEROMETER_EVENT_ROTATION_CHECK
06-27 13:10:45.509 I/VCONF   ( 2845): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0xe125) called
06-27 13:10:45.509 I/VCONF   ( 2845): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0x17651) called
06-27 13:10:45.514 I/VCONF   ( 2845): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0x13ab1) called
06-27 13:10:45.514 I/VCONF   ( 2845): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0x12bdd) called
06-27 13:10:45.514 I/VCONF   ( 2845): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0x13591) called
06-27 13:10:45.514 I/VCONF   ( 2845): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0x15f9d) called
06-27 13:10:45.514 I/VCONF   ( 2845): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0x122a5) called
06-27 13:10:45.514 I/VCONF   ( 3156): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0xb6f05929) called
06-27 13:10:45.514 I/VCONF   ( 3039): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0xeb6d) called
06-27 13:10:45.514 I/VCONF   ( 3084): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0xdfe5) called
06-27 13:10:45.519 I/VCONF   ( 2844): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0x14095) called
06-27 13:10:45.519 D/SECURITY_SERVER( 2844): security-server-client.c: security_server_request_cookie(427) > Client: cookie request sent
06-27 13:10:45.519 I/VCONF   ( 3149): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0xb6f41b20) called
06-27 13:10:45.519 I/VCONF   ( 2847): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/pm/state(3) success
06-27 13:10:45.519 D/SYSTEM_SERVER( 2847): led.c: led_display_changed_cb(120) > display status : 3
06-27 13:10:45.519 D/DEVICE_PLUGIN( 2847): device_manager_plugin_exynos.c: OEM_sys_set_svcled_color(1265) > RGB: [65280], LED_On_ms: [0], LED_Off_ms: [0] 
06-27 13:10:45.524 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1740) > Server: new connection has been accepted: 8
06-27 13:10:45.524 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1750) > Server: Creating a new thread: 0
06-27 13:10:45.529 I/VCONF   ( 4263): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0xb528e8e1) called
06-27 13:10:45.529 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_thread(1472) > Cookie request received
06-27 13:10:45.529 I/SENSOR  ( 4263): client.cpp:lcd_off_cb(794)> LCD OFF noti to setting(4263)
06-27 13:10:45.529 I/VCONF   ( 3748): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0xb424fb21) called
06-27 13:10:45.529 D/SECURITY_SERVER( 2611): security-server-main.c: authorize_SS_API_caller_socket(179) > Checking client SMACK access to SS API
06-27 13:10:45.534 I/VCONF   ( 3731): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0xb424fb21) called
06-27 13:10:45.534 D/SYSTEM_SERVER( 2847): led.c: led_mode_to_device(109) > on : 0, off : 0, val : 0
06-27 13:10:45.539 D/SECURITY_SERVER( 2611): security-server-cookie.c: search_existing_cookie(154) > cookie found
06-27 13:10:45.539 D/SECURITY_SERVER( 2611): security-server-cookie.c: create_cookie_item(355) > Existing cookie found
06-27 13:10:45.539 D/SECURITY_SERVER( 2844): security-server-client.c: security_server_request_cookie(446) > Client: cookie received
06-27 13:10:45.539 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1740) > Server: new connection has been accepted: 9
06-27 13:10:45.539 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1750) > Server: Creating a new thread: 1
06-27 13:10:45.544 D/SECURITY_SERVER( 2611): security-server-main.c: process_cookie_request(562) > Server: Cookie has been sent to client
06-27 13:10:45.544 D/SECURITY_SERVER( 2611): security-server-comm.c: safe_server_sock_close(154) > Server: Closing server socket
06-27 13:10:45.544 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_thread(1484) > Privilege check (new mode) received
06-27 13:10:45.544 D/SECURITY_SERVER( 2611): security-server-main.c: authorize_SS_API_caller_socket(179) > Checking client SMACK access to SS API
06-27 13:10:45.544 D/SYSTEM_SERVER( 2847): led.c: led_mode_to_device(110) > color : ff00
06-27 13:10:45.544 I/POWER_MANAGER( 2847): llinterface.c: backlight_off(374) > LCD off
06-27 13:10:45.544 I/POWER_MANAGER( 2847): x-lcd-on.c: pm_x_set_lcd_backlight(39) > Backlight on=0
06-27 13:10:45.549 I/POWER_MANAGER( 5467): x-lcd-on.c: pm_x_set_lcd_backlight(66) > [1] Child proccess for LCD 0 was created (off)
06-27 13:10:45.554 D/SECURITY_SERVER( 2611): security-server-cookie.c: search_cookie_new(280) > cookie has been found
06-27 13:10:45.559 D/SECURITY_SERVER( 2611): security-server-cookie.c: search_cookie_new(285) > SMACK have access returned 1
06-27 13:10:45.559 D/SECURITY_SERVER( 2611): security-server-main.c: process_check_privilege_new_request(699) > We found the cookie with w rights and pid:2689
06-27 13:10:45.559 D/SECURITY_SERVER( 2611): security-server-main.c: process_check_privilege_new_request(700) > Cookie comparison succeeded. Access granted.
06-27 13:10:45.579 D/SECURITY_SERVER( 2611): security-server-comm.c: safe_server_sock_close(154) > Server: Closing server socket
06-27 13:10:45.584 I/Xorg    ( 2589): (II) > [SECURE_LOG] [XDBG][_traceClientState] id:32, conn_fd:57, pid:5467, uid:0, name:/usr/bin/xset (ClientStateInitial)
06-27 13:10:45.689 I/Xorg    ( 2589): (II) [DPMS][SECOutputDpms] 	 Reqeust DPMS OFF (LVDS1)
06-27 13:10:46.159 I/Xorg    ( 2589): (II) [DPMS][SECOutputDpms] 	 Success DPMS request (LVDS1)
06-27 13:10:46.169 I/POWER_MANAGER( 2847): llinterface.c: system_pre_suspend(247) > enter system pre suspend
06-27 13:10:46.169 I/SYSTEM_SERVER( 2847): core.c: default_action(1103) > timout set: S_LCDOFF state 1 sec
06-27 13:10:46.194 I/VCONF   ( 2847): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0xe310) called
06-27 13:10:46.199 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:10:46.199 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:10:46.199 I/VCONF   ( 2847): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0x28710) called
06-27 13:10:46.199 I/Xorg    ( 2589): (II) > [SECURE_LOG] [XDBG][_traceClientState] id:32, conn_fd:57, pid:5467, uid:0, name:/usr/bin/xset (ClientStateGone)
06-27 13:10:46.199 D/SYSTEM_SERVER( 2847): proc-handler.c: siop_level_action(157) > siop level is : 0(0x1)
06-27 13:10:46.199 D/DEVICE_PLUGIN( 2847): device_manager_siop.c: OEM_sys_set_siop_control(219) > level 0, mode 1
06-27 13:10:46.199 D/DEVICE_PLUGIN( 2847): device_manager_siop.c: OEM_sys_set_siop_control(221) > current_siop {-1, -1, -1, 0, 60}
06-27 13:10:46.199 D/DEVICE_PLUGIN( 2847): device_manager_siop.c: OEM_sys_set_siop_control(223) > new_siop {-2, -2, 1500, -2, -2}
06-27 13:10:46.204 D/DEVICE_PLUGIN( 2847): device_manager_siop.c: OEM_sys_set_siop_control(243) > battery_charing current 1500
06-27 13:10:46.214 I/VCONF   ( 2847): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/pm/state) is changed. cb(0xb59ac8e1) called
06-27 13:10:46.214 I/SENSOR  ( 2847): client.cpp:lcd_off_cb(794)> LCD OFF noti to system_server(2847)
06-27 13:10:46.214 I/SENSOR  ( 2847): client.cpp:lcd_off_cb(802)> Paused LIGHT_SENSOR(0) for system_server(2847)
06-27 13:10:46.219 I/SENSOR  ( 2847): client.cpp:sf_stop(1805)> system_server(2847) stops with LIGHT_SENSOR[0]
06-27 13:10:46.219 E/SENSOR  ( 2684): light-processor.cpp:stop(311)> ambi_processor processor real Stopping
06-27 13:10:46.219 I/SENSOR  ( 2684): light-sensor.cpp:stop(459)> light_sensor client cnt = 1
06-27 13:10:46.239 I/SENSOR  ( 2847): client.cpp:lcd_off_cb(802)> Paused ACCELEROMETER_SENSOR(1) for system_server(2847)
06-27 13:10:46.239 I/SENSOR  ( 2847): client.cpp:sf_stop(1805)> system_server(2847) stops with ACCELEROMETER_SENSOR[1]
06-27 13:10:46.239 I/SENSOR  ( 2684): accel-processor.cpp:stop(639)> accel_processor processor real Stopping
06-27 13:10:46.239 I/SENSOR  ( 2684): accel-sensor.cpp:stop(605)> Accel sensor real stopping, client cnt = 0
06-27 13:10:46.384 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:10:46.384 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:10:46.389 I/SENSOR  ( 5470): client.cpp:good_bye(743)> Good bye! sys_event(5470)
06-27 13:10:46.459 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:10:46.459 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:10:46.459 I/SENSOR  ( 5472): client.cpp:good_bye(743)> Good bye! sys_event(5472)
06-27 13:10:47.174 I/SYSTEM_SERVER( 2847): core.c: timeout_handler(892) > Time out state S_LCDOFF
06-27 13:10:47.174 I/SYSTEM_SERVER( 2847): core.c: default_check(1149) > trans_cond : 4
06-27 13:10:47.174 E/SYSTEM_SERVER( 2847): core.c: print_node(265) > over 1670 s, pid:  4581, lock time: Thu Jun 27 12:42:57 2013
06-27 13:10:47.174 E/SYSTEM_SERVER( 2847): core.c: print_node(265) > over 1670 s, pid:  2847, lock time: Thu Jun 27 12:42:57 2013
06-27 13:10:47.174 I/SYSTEM_SERVER( 2847): core.c: default_trans(947) > S_LCDOFF -> S_SLEEP : check fail
06-27 13:10:47.234 E/SENSOR  ( 2684): accel-processor.cpp:working(425)> is_data_ready() is failed, err_count = 8
06-27 13:10:49.994 D/DEVICED ( 2689): dbus.c: append_variant(55) > data : lcdoff
06-27 13:10:49.994 D/DEVICED ( 2689): dbus.c: append_variant(55) > data : staycurstate
06-27 13:10:49.994 D/DEVICED ( 2689): dbus.c: append_variant(55) > data : NULL
06-27 13:10:50.004 I/SYSTEM_SERVER( 2847): core.c: poll_callback(1266) > process pid(2689) pm_control condition : 4 
06-27 13:10:50.004 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_add(217) > new action called : active
06-27 13:10:50.004 I/SYSTEM_SERVER( 2847): core.c: proc_condition(498) > [SECURE_LOG] [S_LCDOFF] locked by pid 2689 - process /usr/bin/alarm-server
06-27 13:10:50.004 I/SYSTEM_SERVER( 2847): core.c: proc_condition(537) > margin timeout (1 seconds)
06-27 13:10:50.004 I/VCONF   ( 2847): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/private/sysman/enhance_pid(2689) success
06-27 13:10:50.004 I/VCONF   ( 2847): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/private/sysman/enhance_pid) is changed. cb(0x36ce8) called
06-27 13:10:50.009 D/DEVICED ( 2689): display.c: display_lock_state(616) > org.tizen.system.deviced.display-lockstate : 0
06-27 13:10:50.034 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_del_bypid(285) > action deleted : active
06-27 13:10:50.034 D/DEVICED ( 2689): dbus.c: append_variant(55) > data : lcdoff
06-27 13:10:50.034 I/VCONF   ( 2844): vconf.c: vconf_set_bool(1476) > [SECURE_LOG] memory/sat/normal_priority_available(1) success
06-27 13:10:50.034 D/DEVICED ( 2689): dbus.c: append_variant(55) > data : sleepmargin
06-27 13:10:50.044 D/DEVICED ( 2844): dbus.c: append_variant(55) > data : lcdoff
06-27 13:10:50.044 I/SYSTEM_SERVER( 2847): core.c: poll_callback(1266) > process pid(2689) pm_control condition : 40 
06-27 13:10:50.044 D/DEVICED ( 2844): dbus.c: append_variant(55) > data : staycurstate
06-27 13:10:50.044 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_add(217) > new action called : inactive
06-27 13:10:50.049 D/DEVICED ( 2844): dbus.c: append_variant(55) > data : NULL
06-27 13:10:50.049 I/SYSTEM_SERVER( 2847): core.c: proc_condition(523) > [SECURE_LOG] [S_LCDOFF] unlocked by pid 2689 - process /usr/bin/alarm-server
06-27 13:10:50.049 I/SYSTEM_SERVER( 2847): core.c: proc_condition(537) > margin timeout (1 seconds)
06-27 13:10:50.054 I/VCONF   ( 2847): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/private/sysman/enhance_pid(2689) success
06-27 13:10:50.054 D/DEVICED ( 2689): display.c: display_unlock_state(663) > org.tizen.system.deviced.display-unlockstate : 0
06-27 13:10:50.059 I/SYSTEM_SERVER( 2847): core.c: poll_callback(1266) > process pid(2844) pm_control condition : 4 
06-27 13:10:50.059 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_add(217) > new action called : active
06-27 13:10:50.059 I/SYSTEM_SERVER( 2847): core.c: proc_condition(498) > [SECURE_LOG] [S_LCDOFF] locked by pid 2844 - process /usr/bin/starter
06-27 13:10:50.059 I/SYSTEM_SERVER( 2847): core.c: proc_condition(537) > margin timeout (1 seconds)
06-27 13:10:50.064 D/DEVICED ( 2844): display.c: display_lock_state(616) > org.tizen.system.deviced.display-lockstate : 0
06-27 13:10:50.069 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1740) > Server: new connection has been accepted: 8
06-27 13:10:50.069 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1750) > Server: Creating a new thread: 0
06-27 13:10:50.069 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1351) > Check privilige by PID called
06-27 13:10:50.069 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1352) > PID 2844
06-27 13:10:50.069 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1353) > OBJECT: aul::launch
06-27 13:10:50.069 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1354) > ACCESS_RIGHTS x
06-27 13:10:50.069 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1740) > Server: new connection has been accepted: 9
06-27 13:10:50.074 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1750) > Server: Creating a new thread: 1
06-27 13:10:50.074 D/SECURITY_SERVER( 2611): security-server-comm.c: safe_server_sock_close(154) > Server: Closing server socket
06-27 13:10:50.079 I/VCONF   ( 2847): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/private/sysman/enhance_pid) is changed. cb(0x36ce8) called
06-27 13:10:50.079 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_del_bypid(285) > action deleted : inactive
06-27 13:10:50.084 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_thread(1514) > PID privilege check request received
06-27 13:10:50.084 D/SECURITY_SERVER( 2611): security-server-main.c: authorize_SS_API_caller_socket(179) > Checking client SMACK access to SS API
06-27 13:10:50.089 I/VCONF   ( 2847): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/private/sysman/enhance_pid(2844) success
06-27 13:10:50.089 D/SECURITY_SERVER( 2611): security-server-comm.c: recv_pid_privilege_request(2078) > Received PID: 2844
06-27 13:10:50.089 D/SECURITY_SERVER( 2611): security-server-comm.c: recv_pid_privilege_request(2079) > Received object: aul::launch
06-27 13:10:50.089 D/SECURITY_SERVER( 2611): security-server-comm.c: recv_pid_privilege_request(2080) > Received privileges: x
06-27 13:10:50.089 D/SECURITY_SERVER( 2611): security-server-main.c: process_pid_privilege_check(1111) > smack_pid_have_access returned 1
06-27 13:10:50.089 I/VCONF   ( 2847): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/private/sysman/enhance_pid) is changed. cb(0x36ce8) called
06-27 13:10:50.089 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_del_bypid(285) > action deleted : active
06-27 13:10:50.089 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1392) > Client: There is privilege match
06-27 13:10:50.099 D/SECURITY_SERVER( 2611): security-server-comm.c: safe_server_sock_close(154) > Server: Closing server socket
06-27 13:10:50.104 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1740) > Server: new connection has been accepted: 8
06-27 13:10:50.104 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1750) > Server: Creating a new thread: 0
06-27 13:10:50.104 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1351) > Check privilige by PID called
06-27 13:10:50.104 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1352) > PID 2844
06-27 13:10:50.104 D/SECURITY_SERVER( 2611): security-server-comm.c: safe_server_sock_close(154) > Server: Closing server socket
06-27 13:10:50.104 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1353) > OBJECT: aul::launch
06-27 13:10:50.104 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1354) > ACCESS_RIGHTS x
06-27 13:10:50.104 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1740) > Server: new connection has been accepted: 8
06-27 13:10:50.104 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1750) > Server: Creating a new thread: 0
06-27 13:10:50.109 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_thread(1514) > PID privilege check request received
06-27 13:10:50.109 D/SECURITY_SERVER( 2611): security-server-main.c: authorize_SS_API_caller_socket(179) > Checking client SMACK access to SS API
06-27 13:10:50.109 D/SECURITY_SERVER( 2611): security-server-comm.c: recv_pid_privilege_request(2078) > Received PID: 2844
06-27 13:10:50.109 D/SECURITY_SERVER( 2611): security-server-comm.c: recv_pid_privilege_request(2079) > Received object: aul::launch
06-27 13:10:50.109 D/SECURITY_SERVER( 2611): security-server-comm.c: recv_pid_privilege_request(2080) > Received privileges: x
06-27 13:10:50.109 D/SECURITY_SERVER( 2611): security-server-main.c: process_pid_privilege_check(1111) > smack_pid_have_access returned 1
06-27 13:10:50.114 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1392) > Client: There is privilege match
06-27 13:10:50.119 D/SECURITY_SERVER( 2611): security-server-comm.c: safe_server_sock_close(154) > Server: Closing server socket
06-27 13:10:50.189 D/APP2EXT ( 2763): app2ext_interface.c: app2ext_get_app_location(127) >  app path in external memory not accesible
06-27 13:10:50.189 D/APP2EXT ( 2763): app2ext_interface.c: app2ext_get_app_location(138) >  app path in internal memory not accesible
06-27 13:10:50.189 D/MDM     ( 2763): mdm.c: mdm_get_service(118) > trying to lock the Mutex
06-27 13:10:50.189 D/MDM     ( 2763): mdm.c: mdm_get_service(118) > Mutex locked
06-27 13:10:50.189 W/MDM     ( 2763): client.c: mdm_client_connect(180) > [0;34m* Warning * please register a client for activating a server: 111.[0;m
06-27 13:10:50.189 D/MDM     ( 2763): mdm.c: mdm_get_service(132) > Mutex unlocked
06-27 13:10:50.199 I/VCONF   ( 2844): vconf.c: vconf_set_str(1553) > [SECURE_LOG] db/setting/3rd_lock_pkg_name(com.samsung.draglock) success
06-27 13:10:50.199 D/SYSTEM_SERVER( 2847): sysnoti.c: print_sysnoti_msg(52) > [SECURE_LOG] pid : 2844 name: starter cmd : 1 type : oomadj_set path : (null)
06-27 13:10:50.199 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_add(217) > new action called : oomadj_set
06-27 13:10:50.199 I/SYSTEM_SERVER( 2847): proc-handler.c: set_oomadj_action(294) > OOMADJ_SET : pid 5477, new_oomadj -17
06-27 13:10:50.199 D/SYSTEM_SERVER( 2847): proc-handler.c: ss_memcg_move_group(206) > [SECURE_LOG] ss_memcg_move_group : draglock, pid = 5477
06-27 13:10:50.199 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_del_bypid(285) > action deleted : oomadj_set
06-27 13:10:50.199 D/SECURITY_SERVER( 2844): security-server-client.c: security_server_request_cookie(427) > Client: cookie request sent
06-27 13:10:50.199 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1740) > Server: new connection has been accepted: 8
06-27 13:10:50.199 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1750) > Server: Creating a new thread: 0
06-27 13:10:50.204 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_thread(1472) > Cookie request received
06-27 13:10:50.204 D/SECURITY_SERVER( 2611): security-server-main.c: authorize_SS_API_caller_socket(179) > Checking client SMACK access to SS API
06-27 13:10:50.204 D/SECURITY_SERVER( 2611): security-server-cookie.c: search_existing_cookie(154) > cookie found
06-27 13:10:50.204 D/SECURITY_SERVER( 2611): security-server-cookie.c: create_cookie_item(355) > Existing cookie found
06-27 13:10:50.204 D/SECURITY_SERVER( 2844): security-server-client.c: security_server_request_cookie(446) > Client: cookie received
06-27 13:10:50.209 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1740) > Server: new connection has been accepted: 9
06-27 13:10:50.209 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1750) > Server: Creating a new thread: 1
06-27 13:10:50.209 D/SECURITY_SERVER( 2611): security-server-main.c: process_cookie_request(562) > Server: Cookie has been sent to client
06-27 13:10:50.209 D/SECURITY_SERVER( 2611): security-server-comm.c: safe_server_sock_close(154) > Server: Closing server socket
06-27 13:10:50.209 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_thread(1484) > Privilege check (new mode) received
06-27 13:10:50.209 D/SECURITY_SERVER( 2611): security-server-main.c: authorize_SS_API_caller_socket(179) > Checking client SMACK access to SS API
06-27 13:10:50.214 D/SECURITY_SERVER( 2611): security-server-cookie.c: search_cookie_new(280) > cookie has been found
06-27 13:10:50.214 D/SECURITY_SERVER( 2611): security-server-cookie.c: search_cookie_new(285) > SMACK have access returned 1
06-27 13:10:50.219 D/SECURITY_SERVER( 2611): security-server-main.c: process_check_privilege_new_request(699) > We found the cookie with w rights and pid:2689
06-27 13:10:50.219 D/SECURITY_SERVER( 2611): security-server-main.c: process_check_privilege_new_request(700) > Cookie comparison succeeded. Access granted.
06-27 13:10:50.224 D/FEEDBACK( 2844): feedback-internal.c: _feedback_play_led(597) > LED condition is OFF (ledstatus : 0)
06-27 13:10:50.229 D/FEEDBACK( 2844): feedback-internal.c: _feedback_play_sound(575) > Play success! SND filename is /opt/usr/share/feedback/sound/operation/lock.wav
06-27 13:10:50.239 I/VCONF   ( 3061): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(db/setting/3rd_lock_pkg_name) is changed. cb(0xb6d8afb1) called
06-27 13:10:50.244 I/SYSTEM_SERVER( 2847): core.c: poll_callback(1266) > process pid(2628) pm_control condition : 4 
06-27 13:10:50.249 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_add(217) > new action called : active
06-27 13:10:50.249 I/SYSTEM_SERVER( 2847): core.c: proc_condition(498) > [SECURE_LOG] [S_LCDOFF] locked by pid 2628 - process /usr/bin/pulseaudio
06-27 13:10:50.249 I/SYSTEM_SERVER( 2847): core.c: proc_condition(537) > margin timeout (1 seconds)
06-27 13:10:50.249 I/VCONF   ( 2847): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/private/sysman/enhance_pid(2628) success
06-27 13:10:50.249 I/VCONF   ( 2847): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/private/sysman/enhance_pid) is changed. cb(0x36ce8) called
06-27 13:10:50.249 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_del_bypid(285) > action deleted : active
06-27 13:10:50.279 D/SECURITY_SERVER( 2611): security-server-comm.c: safe_server_sock_close(154) > Server: Closing server socket
06-27 13:10:50.389 I/Xorg    ( 2589): (II) > [SECURE_LOG] [XDBG][_traceClientState] id:32, conn_fd:57, pid:5477, uid:5000, name:/usr/apps/com.samsung.draglock/bin/draglock (ClientStateInitial)
06-27 13:10:50.679 I/VCONF   ( 2844): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/idle-screen/top(0) success
06-27 13:10:50.684 I/VCONF   ( 2844): vconf.c: vconf_set_str(1553) > [SECURE_LOG] memory/idle-screen/focused_package(com.samsung.draglock) success
06-27 13:10:50.739 D/E17_EXTRA_MODULES( 2639): policy.c: _policy_active_win_change(2148) > [SECURE_LOG] [WM] ACT WIN 0x2c00003(3734) -> 0x4000006(5477)
06-27 13:10:50.759 D/E17_EXTRA_MODULES( 2639): policy.c: _policy_calculate_visibility(4684) > [SECURE_LOG] [WM] SEND VISIBILITY. win:0x4000006 (old:2 -> new:0)
06-27 13:10:50.759 D/E17_EXTRA_MODULES( 2639): policy.c: _policy_calculate_visibility(4684) > [SECURE_LOG] [WM] SEND VISIBILITY. win:0x2c00003 (old:0 -> new:2)
06-27 13:10:50.769 D/SYSTEM_SERVER( 2847): sysnoti.c: print_sysnoti_msg(52) > [SECURE_LOG] pid : 3734 name: menu-screen cmd : 1 type : backgrd path : (null)
06-27 13:10:50.769 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_add(217) > new action called : backgrd
06-27 13:10:50.769 I/VCONF   ( 2847): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/private/sysman/enhance_pid(3734) success
06-27 13:10:50.769 I/VCONF   ( 2847): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/private/sysman/enhance_pid) is changed. cb(0x36ce8) called
06-27 13:10:50.769 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_del_bypid(285) > action deleted : backgrd
06-27 13:10:50.824 I/VCONF   ( 2845): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/idle_lock/state) is changed. cb(0xdd35) called
06-27 13:10:50.829 I/VCONF   ( 2847): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/idle_lock/state) is changed. cb(0x3e2a0) called
06-27 13:10:50.829 I/SYSTEM_SERVER( 2847): core.c: update_display_time(1308) > LOCK : timeout is set by normal(5)
06-27 13:10:50.829 I/VCONF   ( 2844): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/idle_lock/state) is changed. cb(0x12fe1) called
06-27 13:10:50.829 D/DEVICED ( 2844): dbus.c: append_variant(55) > data : lcdoff
06-27 13:10:50.829 D/DEVICED ( 2844): dbus.c: append_variant(55) > data : sleepmargin
06-27 13:10:50.829 I/SYSTEM_SERVER( 2847): core.c: poll_callback(1266) > process pid(2844) pm_control condition : 40 
06-27 13:10:50.829 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_add(217) > new action called : inactive
06-27 13:10:50.829 I/SYSTEM_SERVER( 2847): core.c: proc_condition(523) > [SECURE_LOG] [S_LCDOFF] unlocked by pid 2844 - process /usr/bin/starter
06-27 13:10:50.829 I/SYSTEM_SERVER( 2847): core.c: proc_condition(537) > margin timeout (1 seconds)
06-27 13:10:50.829 I/VCONF   ( 2847): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/private/sysman/enhance_pid(2844) success
06-27 13:10:50.829 I/VCONF   ( 2847): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/private/sysman/enhance_pid) is changed. cb(0x36ce8) called
06-27 13:10:50.829 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_del_bypid(285) > action deleted : inactive
06-27 13:10:50.834 D/DEVICED ( 2844): display.c: display_unlock_state(663) > org.tizen.system.deviced.display-unlockstate : 0
06-27 13:10:50.834 D/SYSTEM_SERVER( 2847): sysnoti.c: print_sysnoti_msg(52) > [SECURE_LOG] pid : 5477 name: draglock cmd : 1 type : foregrd path : (null)
06-27 13:10:50.834 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_add(217) > new action called : foregrd
06-27 13:10:50.834 I/VCONF   ( 2847): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/private/sysman/enhance_pid(5477) success
06-27 13:10:50.834 I/VCONF   ( 2847): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/private/sysman/enhance_pid) is changed. cb(0x36ce8) called
06-27 13:10:50.834 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_del_bypid(285) > action deleted : foregrd
06-27 13:10:51.834 I/SYSTEM_SERVER( 2847): core.c: timeout_handler(892) > Time out state S_LCDOFF
06-27 13:10:51.834 I/SYSTEM_SERVER( 2847): core.c: default_check(1149) > trans_cond : 4
06-27 13:10:51.834 I/SYSTEM_SERVER( 2847): core.c: print_node(269) > pid:  2628, lock time: Thu Jun 27 13:10:50 2013
06-27 13:10:51.834 E/SYSTEM_SERVER( 2847): core.c: print_node(265) > over 1674 s, pid:  4581, lock time: Thu Jun 27 12:42:57 2013
06-27 13:10:51.834 E/SYSTEM_SERVER( 2847): core.c: print_node(265) > over 1674 s, pid:  2847, lock time: Thu Jun 27 12:42:57 2013
06-27 13:10:51.834 I/SYSTEM_SERVER( 2847): core.c: default_trans(947) > S_LCDOFF -> S_SLEEP : check fail
06-27 13:10:52.449 I/SYSTEM_SERVER( 2847): core.c: poll_callback(1266) > process pid(2628) pm_control condition : 40 
06-27 13:10:52.449 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_add(217) > new action called : inactive
06-27 13:10:52.449 I/SYSTEM_SERVER( 2847): core.c: proc_condition(523) > [SECURE_LOG] [S_LCDOFF] unlocked by pid 2628 - process /usr/bin/pulseaudio
06-27 13:10:52.449 I/SYSTEM_SERVER( 2847): core.c: proc_condition(537) > margin timeout (1 seconds)
06-27 13:10:52.449 I/VCONF   ( 2847): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/private/sysman/enhance_pid(2628) success
06-27 13:10:52.454 I/VCONF   ( 2847): vconf-kdb.c: _vconf_kdb_gio_cb(174) > [SECURE_LOG] key(memory/private/sysman/enhance_pid) is changed. cb(0x36ce8) called
06-27 13:10:52.459 D/SYSTEM_SERVER( 2847): queue.c: ss_run_queue_del_bypid(285) > action deleted : inactive
06-27 13:10:53.454 I/SYSTEM_SERVER( 2847): core.c: timeout_handler(892) > Time out state S_LCDOFF
06-27 13:10:53.454 I/SYSTEM_SERVER( 2847): core.c: default_check(1149) > trans_cond : 4
06-27 13:10:53.454 E/SYSTEM_SERVER( 2847): core.c: print_node(265) > over 1676 s, pid:  4581, lock time: Thu Jun 27 12:42:57 2013
06-27 13:10:53.454 E/SYSTEM_SERVER( 2847): core.c: print_node(265) > over 1676 s, pid:  2847, lock time: Thu Jun 27 12:42:57 2013
06-27 13:10:53.454 I/SYSTEM_SERVER( 2847): core.c: default_trans(947) > S_LCDOFF -> S_SLEEP : check fail
06-27 13:11:10.734 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:11:10.734 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:11:40.734 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:11:40.734 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:12:10.734 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:12:10.734 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:12:36.714 I/POWER_MANAGER( 2847): battery.c: update_factor(249) >  sum = 43.500000
06-27 13:12:36.714 I/POWER_MANAGER( 2847): battery.c: update_factor(251) >  avg_factor = 6.214286
06-27 13:12:36.714 I/VCONF   ( 2847): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/pm/battery_timetoempty(72974) success
06-27 13:12:36.714 I/POWER_MANAGER( 2847): battery.c: update_time(275) > update time[0,72974]
06-27 13:12:40.734 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:12:40.734 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:12:46.514 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:12:46.514 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:12:46.519 I/SENSOR  ( 5499): client.cpp:good_bye(743)> Good bye! sys_event(5499)
06-27 13:13:10.734 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:13:10.734 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:13:40.734 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:13:40.734 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:14:10.734 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:14:10.734 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:14:40.734 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:14:40.734 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:14:46.559 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:14:46.559 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:14:46.559 I/SENSOR  ( 5511): client.cpp:good_bye(743)> Good bye! sys_event(5511)
06-27 13:14:57.764 I/VCONF   ( 2686): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/telephony/cell_id(63161347) success
06-27 13:15:06.714 I/POWER_MANAGER( 2847): battery.c: update_factor(249) >  sum = 52.875000
06-27 13:15:06.714 I/POWER_MANAGER( 2847): battery.c: update_factor(251) >  avg_factor = 6.609375
06-27 13:15:06.714 I/VCONF   ( 2847): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/pm/battery_timetoempty(77719) success
06-27 13:15:06.714 I/POWER_MANAGER( 2847): battery.c: update_time(275) > update time[0,77719]
06-27 13:15:10.734 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:15:10.734 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:15:40.734 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:15:40.734 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:16:10.734 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:16:10.734 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:16:19.384 I/PKGMGR  ( 5549): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(139) > [comm]comm_pkg_mgr_server.c:139:pkg_mgr_object_class_init(): called
06-27 13:16:19.384 I/PKGMGR  ( 5549): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(146) > [comm]comm_pkg_mgr_server.c:146:pkg_mgr_object_class_init(): done
06-27 13:16:19.384 I/PKGMGR  ( 5549): comm_pkg_mgr_server.c: pkg_mgr_object_init(88) > [comm]comm_pkg_mgr_server.c:88:pkg_mgr_object_init(): called
06-27 13:16:19.409 I/PKGMGR  ( 5549): comm_pkg_mgr_server.c: pkg_mgr_object_init(125) > [comm]comm_pkg_mgr_server.c:125:pkg_mgr_object_init(): RequestName returns: 1
06-27 13:16:19.414 I/PKGMGR  ( 5549): comm_pkg_mgr_server.c: pkg_mgr_object_init(130) > [comm]comm_pkg_mgr_server.c:130:pkg_mgr_object_init(): Ready to serve requests
06-27 13:16:19.414 I/PKGMGR  ( 5549): comm_pkg_mgr_server.c: pkg_mgr_object_init(134) > [comm]comm_pkg_mgr_server.c:134:pkg_mgr_object_init(): done
06-27 13:16:19.464 I/Xorg    ( 2589): (II) > [SECURE_LOG] [XDBG][_traceClientState] id:33, conn_fd:58, pid:5549, uid:0, name:/usr/bin/pkgmgr-server (ClientStateInitial)
06-27 13:16:19.594 I/VCONF   ( 5549): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb6829cf4) is added for memory/sysman/low_memory. tot cb cnt : 1
06-27 13:16:19.594 I/VCONF   ( 5549): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb6829cf4) is added for memory/sysman/battery_status_low. tot cb cnt : 2
06-27 13:16:19.594 I/VCONF   ( 5549): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb6829cf4) is added for db/menu_widget/language. tot cb cnt : 3
06-27 13:16:19.594 I/VCONF   ( 5549): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb6829cf4) is added for db/menu_widget/regionformat. tot cb cnt : 4
06-27 13:16:19.599 I/VCONF   ( 5549): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb6829cf4) is added for db/menu_widget/regionformat_time1224. tot cb cnt : 5
06-27 13:16:19.599 I/PKGMGR  ( 5549): comm_pkg_mgr_server.c: pkgmgr_request(170) > [comm]comm_pkg_mgr_server.c:170:pkgmgr_request(): Called
06-27 13:16:19.634 I/VCONF   ( 5550): vconf.c: vconf_set_int(1437) > [SECURE_LOG] memory/pkgmgr/status(0) success
06-27 13:16:19.654 I/SENSOR  ( 5550): client.cpp:good_bye(743)> Good bye! pkgmgr-server(5550)
06-27 13:16:21.539 I/VCONF   ( 5549): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(memory/sysman/low_memory) cb is removed. remained noti list total length(4)
06-27 13:16:21.539 I/VCONF   ( 5549): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(memory/sysman/battery_status_low) cb is removed. remained noti list total length(3)
06-27 13:16:21.544 I/VCONF   ( 5549): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(db/menu_widget/language) cb is removed. remained noti list total length(2)
06-27 13:16:21.544 I/VCONF   ( 5549): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(db/menu_widget/regionformat) cb is removed. remained noti list total length(1)
06-27 13:16:21.544 I/VCONF   ( 5549): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(db/menu_widget/regionformat_time1224) cb is removed. remained noti list total length(0)
06-27 13:16:21.544 I/VCONF   ( 5549): vconf-kdb.c: _vconf_kdb_del_notify(395) > [SECURE_LOG] all noti list is freed
06-27 13:16:21.549 I/Xorg    ( 2589): (II) > [SECURE_LOG] [XDBG][_traceClientState] id:33, conn_fd:58, pid:5549, uid:0, name:/usr/bin/pkgmgr-server (ClientStateGone)
06-27 13:16:21.569 I/SENSOR  ( 5549): client.cpp:good_bye(743)> Good bye! pkgmgr-server(5549)
06-27 13:16:36.309 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1740) > Server: new connection has been accepted: 8
06-27 13:16:36.309 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1750) > Server: Creating a new thread: 0
06-27 13:16:36.309 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_thread(1472) > Cookie request received
06-27 13:16:36.309 D/SECURITY_SERVER( 2611): security-server-main.c: authorize_SS_API_caller_socket(179) > Checking client SMACK access to SS API
06-27 13:16:36.314 D/SECURITY_SERVER( 2611): security-server-main.c: process_cookie_request(562) > Server: Cookie has been sent to client
06-27 13:16:36.314 D/SECURITY_SERVER( 2611): security-server-comm.c: safe_server_sock_close(154) > Server: Closing server socket
06-27 13:16:36.514 I/PKGMGR  ( 5711): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(139) > [comm]comm_pkg_mgr_server.c:139:pkg_mgr_object_class_init(): called
06-27 13:16:36.519 I/PKGMGR  ( 5711): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(146) > [comm]comm_pkg_mgr_server.c:146:pkg_mgr_object_class_init(): done
06-27 13:16:36.519 I/PKGMGR  ( 5711): comm_pkg_mgr_server.c: pkg_mgr_object_init(88) > [comm]comm_pkg_mgr_server.c:88:pkg_mgr_object_init(): called
06-27 13:16:36.544 I/PKGMGR  ( 5711): comm_pkg_mgr_server.c: pkg_mgr_object_init(125) > [comm]comm_pkg_mgr_server.c:125:pkg_mgr_object_init(): RequestName returns: 1
06-27 13:16:36.544 I/PKGMGR  ( 5711): comm_pkg_mgr_server.c: pkg_mgr_object_init(130) > [comm]comm_pkg_mgr_server.c:130:pkg_mgr_object_init(): Ready to serve requests
06-27 13:16:36.544 I/PKGMGR  ( 5711): comm_pkg_mgr_server.c: pkg_mgr_object_init(134) > [comm]comm_pkg_mgr_server.c:134:pkg_mgr_object_init(): done
06-27 13:16:36.584 I/Xorg    ( 2589): (II) > [SECURE_LOG] [XDBG][_traceClientState] id:33, conn_fd:58, pid:5711, uid:0, name:/usr/bin/pkgmgr-server (ClientStateInitial)
06-27 13:16:36.709 I/VCONF   ( 5711): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb68d1cf4) is added for memory/sysman/low_memory. tot cb cnt : 1
06-27 13:16:36.709 I/VCONF   ( 5711): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb68d1cf4) is added for memory/sysman/battery_status_low. tot cb cnt : 2
06-27 13:16:36.709 I/VCONF   ( 5711): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb68d1cf4) is added for db/menu_widget/language. tot cb cnt : 3
06-27 13:16:36.709 I/VCONF   ( 5711): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb68d1cf4) is added for db/menu_widget/regionformat. tot cb cnt : 4
06-27 13:16:36.709 I/VCONF   ( 5711): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb68d1cf4) is added for db/menu_widget/regionformat_time1224. tot cb cnt : 5
06-27 13:16:36.714 I/PKGMGR  ( 5711): comm_pkg_mgr_server.c: pkgmgr_request(170) > [comm]comm_pkg_mgr_server.c:170:pkgmgr_request(): Called
06-27 13:16:36.714 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1740) > Server: new connection has been accepted: 8
06-27 13:16:36.714 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1750) > Server: Creating a new thread: 0
06-27 13:16:36.714 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_thread(1484) > Privilege check (new mode) received
06-27 13:16:36.714 D/SECURITY_SERVER( 2611): security-server-main.c: authorize_SS_API_caller_socket(179) > Checking client SMACK access to SS API
06-27 13:16:36.714 D/SECURITY_SERVER( 2611): security-server-cookie.c: search_cookie_new(280) > cookie has been found
06-27 13:16:36.714 D/SECURITY_SERVER( 2611): security-server-cookie.c: search_cookie_new(285) > SMACK have access returned 1
06-27 13:16:36.714 D/SECURITY_SERVER( 2611): security-server-main.c: process_check_privilege_new_request(699) > We found the cookie with r rights and pid:5711
06-27 13:16:36.714 D/SECURITY_SERVER( 2611): security-server-main.c: process_check_privilege_new_request(700) > Cookie comparison succeeded. Access granted.
06-27 13:16:36.714 D/SECURITY_SERVER( 2611): security-server-comm.c: safe_server_sock_close(154) > Server: Closing server socket
06-27 13:16:36.844 I/PKGMGR  ( 3758): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:36.844 I/PKGMGR  ( 3758): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:36.844 I/PKGMGR  ( 3758): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:36.844 I/PKGMGR  ( 3728): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:36.844 I/PKGMGR  ( 3728): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:36.844 I/PKGMGR  ( 3728): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:36.849 I/PKGMGR  ( 3748): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:36.849 I/PKGMGR  ( 3748): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:36.849 I/PKGMGR  ( 3748): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:36.849 I/PKGMGR  ( 3061): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:36.849 I/PKGMGR  ( 3061): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:36.849 I/PKGMGR  ( 3061): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:36.849 I/PKGMGR  ( 3260): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:36.849 I/PKGMGR  ( 3260): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:36.849 I/PKGMGR  ( 3260): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:36.849 I/PKGMGR  ( 3149): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:36.849 I/PKGMGR  ( 3149): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:36.849 I/PKGMGR  ( 3149): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:37.009 I/PKGMGR  ( 3758): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:37.009 I/PKGMGR  ( 3758): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:37.009 I/PKGMGR  ( 3758): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:37.009 I/PKGMGR  ( 3728): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:37.009 I/PKGMGR  ( 3728): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:37.009 I/PKGMGR  ( 3728): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:37.009 I/PKGMGR  ( 3748): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:37.009 I/PKGMGR  ( 3748): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:37.009 I/PKGMGR  ( 3748): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:37.014 I/PKGMGR  ( 3061): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:37.014 I/PKGMGR  ( 3061): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:37.014 I/PKGMGR  ( 3061): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:37.014 I/PKGMGR  ( 3260): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:37.014 I/PKGMGR  ( 3260): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:37.014 I/PKGMGR  ( 3260): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:37.014 I/PKGMGR  ( 3149): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:37.014 I/PKGMGR  ( 3149): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:37.014 I/PKGMGR  ( 3149): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:37.019 I/PKGMGR  ( 3758): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:37.029 I/PKGMGR  ( 3728): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:37.029 I/PKGMGR  ( 3728): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:37.029 I/PKGMGR  ( 3728): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:37.029 I/PKGMGR  ( 3758): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:37.029 I/PKGMGR  ( 3061): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:37.039 I/PKGMGR  ( 3260): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:37.039 I/PKGMGR  ( 3260): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:37.039 I/PKGMGR  ( 3260): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:37.039 I/PKGMGR  ( 3748): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:37.039 I/PKGMGR  ( 3149): comm_client_dbus.c: _on_signal_handle_filter(70) > [comm]comm_client_dbus.c:70:_on_signal_handle_filter(): start function
06-27 13:16:37.039 I/PKGMGR  ( 3149): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:37.039 I/PKGMGR  ( 3149): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:37.039 I/PKGMGR  ( 3748): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:37.044 I/PKGMGR  ( 3748): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:37.044 I/PKGMGR  ( 3758): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:37.054 I/SENSOR  ( 5713): client.cpp:good_bye(743)> Good bye! tpk(5713)
06-27 13:16:37.079 I/PKGMGR  ( 3061): comm_client_dbus.c: _on_signal_handle_filter(107) > [comm]comm_client_dbus.c:107:_on_signal_handle_filter(): callback function is end
06-27 13:16:37.079 I/PKGMGR  ( 3061): comm_client_dbus.c: _on_signal_handle_filter(110) > [comm]comm_client_dbus.c:110:_on_signal_handle_filter(): handled signal. exit function
06-27 13:16:38.539 I/VCONF   ( 5711): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(memory/sysman/low_memory) cb is removed. remained noti list total length(4)
06-27 13:16:38.539 I/VCONF   ( 5711): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(memory/sysman/battery_status_low) cb is removed. remained noti list total length(3)
06-27 13:16:38.539 I/VCONF   ( 5711): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(db/menu_widget/language) cb is removed. remained noti list total length(2)
06-27 13:16:38.539 I/VCONF   ( 5711): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(db/menu_widget/regionformat) cb is removed. remained noti list total length(1)
06-27 13:16:38.539 I/VCONF   ( 5711): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(db/menu_widget/regionformat_time1224) cb is removed. remained noti list total length(0)
06-27 13:16:38.539 I/VCONF   ( 5711): vconf-kdb.c: _vconf_kdb_del_notify(395) > [SECURE_LOG] all noti list is freed
06-27 13:16:38.544 I/Xorg    ( 2589): (II) > [SECURE_LOG] [XDBG][_traceClientState] id:33, conn_fd:58, pid:5711, uid:0, name:/usr/bin/pkgmgr-server (ClientStateGone)
06-27 13:16:38.564 I/SENSOR  ( 5711): client.cpp:good_bye(743)> Good bye! pkgmgr-server(5711)
06-27 13:16:40.734 D/SYSTEM_SERVER( 2847): led.c: led_lowbat_changed_cb(147) > lowbat status : 0 [lowbat vconf : 0]
06-27 13:16:40.734 D/SYSTEM_SERVER( 2847): led.c: led_fullbat_changed_cb(158) > fullbat status : 1 [charging vconf : 1]
06-27 13:16:41.724 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1740) > Server: new connection has been accepted: 8
06-27 13:16:41.724 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1750) > Server: Creating a new thread: 0
06-27 13:16:41.724 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1351) > Check privilige by PID called
06-27 13:16:41.724 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1352) > PID 5757
06-27 13:16:41.724 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1353) > OBJECT: aul::launch
06-27 13:16:41.724 D/SECURITY_SERVER( 2763): security-server-client.c: security_server_check_privilege_by_pid(1354) > ACCESS_RIGHTS x
06-27 13:16:41.724 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1740) > Server: new connection has been accepted: 9
06-27 13:16:41.724 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_main_thread(1750) > Server: Creating a new thread: 1
06-27 13:16:41.729 D/SECURITY_SERVER( 2611): security-server-comm.c: safe_server_sock_close(154) > Server: Closing server socket
06-27 13:16:41.729 D/SECURITY_SERVER( 2611): security-server-main.c: security_server_thread(1514) > PID privilege check request received
06-27 13:16:41.729 D/SECURITY_SERVER( 2611): security-server-main.c: authorize_SS_API_caller_socket(179) > Checking client SMACK access to SS API
06-27 13:16:41.729 D/SECURITY_SERVER( 2611): security-server-comm.c: recv_pid_privilege_request(2078) > Received PID: 5757
06-27 13:16:41.729 D/SECURITY_SERVER( 2611): security-server-comm.c: recv_pid_privilege_request(2079) > Received object: aul::launch
06-27 13:16:41.729 D/SECURITY_SERVER( 2611): security-server-comm.c: recv_pid_privilege_request(2080) > Received privileges: x
06-27 13:16:41.729 D/SECURITY_SERVER( 2611): security-server-main.c: process_pid_privilege_check(1111) > smack_pid_have_access returned 0
06-27 13:16:41.739 D/SECURITY_SERVER( 2611): security-server-comm.c: safe_server_sock_close(154) > Server: Closing server socket
06-27 13:16:41.809 D/APP2EXT ( 2763): app2ext_interface.c: app2ext_get_app_location(127) >  app path in external memory not accesible
06-27 13:16:41.809 D/MDM     ( 2763): mdm.c: mdm_get_service(118) > trying to lock the Mutex
06-27 13:16:41.809 D/MDM     ( 2763): mdm.c: mdm_get_service(118) > Mutex locked
06-27 13:16:41.809 W/MDM     ( 2763): client.c: mdm_client_connect(180) > [0;34m* Warning * please register a client for activating a server: 111.[0;m
06-27 13:16:41.809 D/MDM     ( 2763): mdm.c: mdm_get_service(132) > Mutex unlocked
06-27 13:16:41.949 I/DRM_CLIENT( 5761): drm_client_ipc.cpp: __drm_client_lib_load_constructor(126) > [PID=5761]:[TID=5761]:[drm_client_ipc.cpp:__drm_client_lib_load_constructor:126]:libdrm-client.so.0 loaded!!!
06-27 13:16:41.949 I/DRM_CLIENT( 5761): drm_client_ipc.cpp: __drm_client_lib_load_constructor(139) > [PID=5761]:[TID=5761]:[drm_client_ipc.cpp:__drm_client_lib_load_constructor:139]:Registering the signal handler as SIG_IGN
06-27 13:16:41.949 I/DRM_TRUSTED_CLIENT( 5761): drm_trusted_client_ipc.cpp: __drm_trusted_client_lib_load_constructor(125) > [PID=5761]:[TID=5761]:[drm_trusted_client_ipc.cpp:__drm_trusted_client_lib_load_constructor:125]:libdrm-trusted.so.0 loaded!!!
06-27 13:16:41.954 I/DRM_TRUSTED_CLIENT( 5761): drm_trusted_client_ipc.cpp: __drm_trusted_client_lib_load_constructor(139) > [PID=5761]:[TID=5761]:[drm_trusted_client_ipc.cpp:__drm_trusted_client_lib_load_constructor:139]:Registering the signal handler as SIG_IGN
06-27 13:16:41.954 D/MM_SESSIONMGR( 5761): audio-session-mgr.c: __ASM_init_module(2024) > <ENTER> 
06-27 13:16:41.954 D/MM_SESSIONMGR( 5761): audio-session-mgr.c: __ASM_init_module(2035) > <LEAVE> 
06-27 13:16:41.984 I/Xorg    ( 2589): (II) > [SECURE_LOG] [XDBG][_traceClientState] id:33, conn_fd:58, pid:5761, uid:5000, name:/opt/apps/vMEuS5j7iC/bin/MyHondana (ClientStateInitial)
06-27 13:16:42.019 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb529fcf4) is added for memory/sysman/low_memory. tot cb cnt : 1
06-27 13:16:42.019 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb529fcf4) is added for memory/sysman/battery_status_low. tot cb cnt : 2
06-27 13:16:42.019 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb529fcf4) is added for db/menu_widget/language. tot cb cnt : 3
06-27 13:16:42.019 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb529fcf4) is added for db/menu_widget/regionformat. tot cb cnt : 4
06-27 13:16:42.019 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb529fcf4) is added for db/menu_widget/regionformat_time1224. tot cb cnt : 5
06-27 13:16:42.064 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb3b23825) is added for db/setting/accessibility/tts. tot cb cnt : 6
06-27 13:16:42.064 I/SENSOR  ( 5761): client.cpp:sf_connect(1478)> MyHondana(5761) connects with ACCELEROMETER_SENSOR[0]
06-27 13:16:42.069 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb528e8e1) is added for memory/pm/state. tot cb cnt : 7
06-27 13:16:42.069 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb528d4c9) is added for memory/private/sensor/poweroff. tot cb cnt : 8
06-27 13:16:42.069 I/SENSOR  ( 5761): client.cpp:sf_start(1705)> MyHondana(5761) starts with ACCELEROMETER_SENSOR[0], option: 1
06-27 13:16:42.069 I/SENSOR  ( 5761): client.cpp:sf_start(1729)> sensor start with SENSOR_OPTION_ALWAYS_ON
06-27 13:16:42.069 I/SENSOR  ( 2684): accel-processor.cpp:start(608)> accel_processor processor real starting
06-27 13:16:42.069 I/SENSOR  ( 2684): accel-sensor.cpp:update_polling_interval(497)> interval = [200]
06-27 13:16:42.074 I/SENSOR  ( 2684): accel-sensor.cpp:start(579)> Accel sensor real starting, client cnt = 1
06-27 13:16:42.079 I/SENSOR  ( 5761): client.cpp:sf_stop(1805)> MyHondana(5761) stops with ACCELEROMETER_SENSOR[0]
06-27 13:16:42.079 I/SENSOR  ( 2684): accel-processor.cpp:stop(639)> accel_processor processor real Stopping
06-27 13:16:42.079 I/SENSOR  ( 5761): client.cpp:sf_disconnect(1641)> MyHondana(5761) disconnected with ACCELEROMETER_SENSOR[0]
06-27 13:16:42.079 I/SENSOR  ( 2684): accel-sensor.cpp:stop(605)> Accel sensor real stopping, client cnt = 0
06-27 13:16:42.089 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(memory/pm/state) cb is removed. remained noti list total length(7)
06-27 13:16:42.089 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(memory/private/sensor/poweroff) cb is removed. remained noti list total length(6)
06-27 13:16:42.089 I/SENSOR  ( 5761): client.cpp:sf_check_rotation(2399)> MyHondana(5761) gets ROTATION_EVENT_0 by checking rotation
06-27 13:16:42.139 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb45d258d) is added for memory/sysman/battery_level_status. tot cb cnt : 7
06-27 13:16:42.194 I/Xorg    ( 2589): (II) > [SECURE_LOG] [XDBG][_traceClientState] id:34, conn_fd:59, pid:5761, uid:5000, name:/opt/apps/vMEuS5j7iC/bin/MyHondana (ClientStateInitial)
06-27 13:16:42.284 I/SENSOR  ( 5761): client.cpp:sf_connect(1478)> MyHondana(5761) connects with ACCELEROMETER_SENSOR[0]
06-27 13:16:42.289 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb528e8e1) is added for memory/pm/state. tot cb cnt : 8
06-27 13:16:42.289 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb528d4c9) is added for memory/private/sensor/poweroff. tot cb cnt : 9
06-27 13:16:42.289 I/SENSOR  ( 5761): client.cpp:sf_start(1705)> MyHondana(5761) starts with ACCELEROMETER_SENSOR[0], option: 1
06-27 13:16:42.289 I/SENSOR  ( 5761): client.cpp:sf_start(1729)> sensor start with SENSOR_OPTION_ALWAYS_ON
06-27 13:16:42.289 I/SENSOR  ( 2684): accel-processor.cpp:start(608)> accel_processor processor real starting
06-27 13:16:42.289 I/SENSOR  ( 2684): accel-sensor.cpp:update_polling_interval(497)> interval = [200]
06-27 13:16:42.294 I/SENSOR  ( 2684): accel-sensor.cpp:start(579)> Accel sensor real starting, client cnt = 1
06-27 13:16:42.294 I/SENSOR  ( 5761): client.cpp:sf_stop(1805)> MyHondana(5761) stops with ACCELEROMETER_SENSOR[0]
06-27 13:16:42.294 I/SENSOR  ( 2684): accel-processor.cpp:stop(639)> accel_processor processor real Stopping
06-27 13:16:42.299 I/SENSOR  ( 5761): client.cpp:sf_disconnect(1641)> MyHondana(5761) disconnected with ACCELEROMETER_SENSOR[0]
06-27 13:16:42.309 I/SENSOR  ( 2684): accel-sensor.cpp:stop(605)> Accel sensor real stopping, client cnt = 0
06-27 13:16:42.309 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(memory/pm/state) cb is removed. remained noti list total length(8)
06-27 13:16:42.309 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(memory/private/sensor/poweroff) cb is removed. remained noti list total length(7)
06-27 13:16:42.309 I/SENSOR  ( 5761): client.cpp:sf_check_rotation(2399)> MyHondana(5761) gets ROTATION_EVENT_0 by checking rotation
06-27 13:16:42.309 I/SENSOR  ( 5761): client.cpp:sf_connect(1478)> MyHondana(5761) connects with ACCELEROMETER_SENSOR[0]
06-27 13:16:42.309 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb528e8e1) is added for memory/pm/state. tot cb cnt : 8
06-27 13:16:42.309 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_add_notify(318) > [SECURE_LOG] cb(0xb528d4c9) is added for memory/private/sensor/poweroff. tot cb cnt : 9
06-27 13:16:42.309 I/SENSOR  ( 5761): client.cpp:sf_start(1705)> MyHondana(5761) starts with ACCELEROMETER_SENSOR[0], option: 1
06-27 13:16:42.309 I/SENSOR  ( 5761): client.cpp:sf_start(1729)> sensor start with SENSOR_OPTION_ALWAYS_ON
06-27 13:16:42.309 I/SENSOR  ( 2684): accel-processor.cpp:start(608)> accel_processor processor real starting
06-27 13:16:42.309 I/SENSOR  ( 2684): accel-sensor.cpp:update_polling_interval(497)> interval = [200]
06-27 13:16:42.314 I/SENSOR  ( 2684): accel-sensor.cpp:start(579)> Accel sensor real starting, client cnt = 1
06-27 13:16:42.319 I/SENSOR  ( 5761): client.cpp:sf_stop(1805)> MyHondana(5761) stops with ACCELEROMETER_SENSOR[0]
06-27 13:16:42.319 I/SENSOR  ( 2684): accel-processor.cpp:stop(639)> accel_processor processor real Stopping
06-27 13:16:42.319 I/SENSOR  ( 5761): client.cpp:sf_disconnect(1641)> MyHondana(5761) disconnected with ACCELEROMETER_SENSOR[0]
06-27 13:16:42.329 E/SENSOR  ( 2684): cmutex.cpp:lock(79)> accel-sensor.cpp:update_value(278) is waiting for getting the lock(0x1c36c) owned in accel-sensor.cpp:stop(600)
06-27 13:16:42.339 E/SENSOR  ( 2684): cmutex.cpp:lock(92)> accel-sensor.cpp:update_value(278) acquires lock after waiting 9989us, the lock(0x1c36c) was previously owned in accel-sensor.cpp:stop(600)
06-27 13:16:42.339 E/SENSOR  ( 2684): accel-sensor.cpp:update_value(281)> Invaild gyro sensor node handle , handle : -1
06-27 13:16:42.339 E/SENSOR  ( 2684): cmutex.cpp:lock(79)> accel-processor.cpp:working(423) is waiting for getting the lock(0x1cf60) owned in accel-processor.cpp:stop(632)
06-27 13:16:42.339 I/SENSOR  ( 2684): accel-sensor.cpp:stop(605)> Accel sensor real stopping, client cnt = 0
06-27 13:16:42.339 E/SENSOR  ( 2684): cmutex.cpp:lock(92)> accel-processor.cpp:working(423) acquires lock after waiting 92us, the lock(0x1cf60) was previously owned in accel-processor.cpp:stop(632)
06-27 13:16:42.339 E/SENSOR  ( 2684): accel-processor.cpp:working(425)> is_data_ready() is failed, err_count = 9
06-27 13:16:42.339 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(memory/pm/state) cb is removed. remained noti list total length(8)
06-27 13:16:42.339 I/VCONF   ( 5761): vconf-kdb.c: _vconf_kdb_del_notify(369) > [SECURE_LOG] key(memory/private/sensor/poweroff) cb is removed. remained noti list total length(7)
06-27 13:16:42.339 I/SENSOR  ( 5761): client.cpp:sf_check_rotation(2399)> MyHondana(5761) gets ROTATION_EVENT_0 by checking rotation
06-27 13:16:42.389 W/MM_SESSIONMGR( 5761): audio-session-mgr.c: __ASM_signal_handler(1946) > ENTER, sig.num(11)
06-27 13:16:42.389 W/MM_SESSIONMGR( 5761): audio-session-mgr.c: __ASM_signal_handler(2013) > LEAVE
06-27 13:16:42.514 D/SYSTEM_SERVER( 2847): bs.c: crash_arg_parser(326) > [SECURE_LOG] vnum 43 vanum 43
06-27 13:16:42.514 D/SYSTEM_SERVER( 2847): bs.c: launch_crash_worker(430) > [SECURE_LOG] crash_worker args(S MyHondana 1372306602 5761 /opt/apps/vMEuS5j7iC/bin/MyHondana)
06-27 13:16:42.514 D/SYSTEM_SERVER( 2847): bs.c: launch_crash_worker(432) > [SECURE_LOG] (SMyHondana1372306602)
End of latest debug message
